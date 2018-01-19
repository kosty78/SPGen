using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SPGen.FileManager.Models;

namespace SPGen.FileManager
{
    public class SyncManager : ISyncManager
    {
        private int _unusedPath;
        public TreeNode[] PopulateFiles(string folder, string syncFile, out IDictionary<int, string> filesToSync)
        {
            _unusedPath = folder.Length;

            filesToSync = GetSyncedItems(syncFile).ToDictionary(_ => _.Path.GetHashCode(), _ => _.Path);
            var node = new TreeNode();

            return Populate(folder, node.Nodes, filesToSync);
        }

        private Item[] GetSyncedItems(string syncFile)
        {
            return JsonConvert.DeserializeObject<Item[]>(GetFile(syncFile));
        }

        private TreeNode[] Populate(string currentFolder, TreeNodeCollection actualFiles,
            IDictionary<int, string> filesToSync)
        {
            var folders = Directory.GetDirectories(currentFolder);
            foreach (var folder in folders)
            {
                var node = new FileTreeNode(folder.Remove(0, _unusedPath), true);
                Populate(folder, node.Nodes, filesToSync);
                actualFiles.Add(node);
            }
            var files = Directory.GetFiles(currentFolder);
            foreach (var file in files)
            {
                var node = new FileTreeNode(file.Remove(0, _unusedPath), false);
                actualFiles.Add(node);
                if (filesToSync.ContainsKey(node.Hash))
                {
                    node.IsSelectedFile = true;
                    node.BackColor = Constants.SelectedFile;
                    node.Parent?.Expand();
                }
            }
            return actualFiles.Cast<TreeNode>().ToArray();
        }

        public void SaveToFile(IDictionary<int, string> filesToSync, string syncFile)
        {
            var files = filesToSync.OrderBy(_=>_.Value).Select(_ => new Item(_.Value)).ToArray();
            var json = JsonConvert.SerializeObject(files);

            SaveFile(json, syncFile);
        }

        public string GetFile(string file)
        {
            using (var r = new StreamReader(file))
            {
                return r.ReadToEnd();
            }
        }
        public void SaveFile(string file, string fileName)
        {
            using (var wr = new StreamWriter(fileName,false))
            {
                wr.Write(file);
            }
        }
    }
}