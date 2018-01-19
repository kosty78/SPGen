using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using SPGen.ItemManager.Models;
using SPGen.ItemsManager;

namespace SPGen.ItemManager
{
    public class SyncManager : ISyncManager
    {
        public TreeNode[] PopulateItems(string folder, string syncFile, out IDictionary<int, Item> itemsToSync)
        {
            itemsToSync = GetSyncedItems(syncFile).ToDictionary(_ => _.Path.GetHashCode(), _ => _);
            var node = new TreeNode();

            return Populate(folder, node.Nodes, itemsToSync);
        }

        private Item[] GetSyncedItems(string syncFile)
        {
            return JsonConvert.DeserializeObject<Item[]>(GetFile(syncFile));
        }

        private TreeNode[] Populate(string currentFolder, TreeNodeCollection actualFiles,
            IDictionary<int, Item> filesToSync)
        {

            return actualFiles.Cast<TreeNode>().ToArray();
        }

        public void SaveToFile(IDictionary<int, Item> itemsToSync, string syncFile)
        {
            var files = itemsToSync.OrderBy(_=>_.Value.Path).Select(_=>_.Value).ToArray();
            var json = JsonConvert.SerializeObject(files).Replace("},", "},\n"); ;

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