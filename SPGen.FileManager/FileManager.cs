using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SPGen.FileManager.Comparers;
using SPGen.FileManager.Models;
using Item = SPGen.FileManager.Models.Item;

namespace SPGen.FileManager
{
    public class FileManager : IFileManager
    {
        public IEnumerable<Item> PopulateFiles(string folder, string syncFile)
        {
            IList<Item> items = new List<Item>();
            var syncedItems = GetSyncedItems(syncFile);

            return Populate(folder, items, syncedItems.Select(_ => _.Path).ToArray());
        }

        private Item[] GetSyncedItems(string syncFile)
        {
            return JsonConvert.DeserializeObject<Item[]>(syncFile);
        }

        private IEnumerable<Item> Populate(string currentFolder, IList<Item> actualFiles, IEnumerable<string> syncedItems)
        {
            var files = Directory.GetFiles(currentFolder);
            foreach (var file in files)
            {
                var item = new Item(file);
                if (syncedItems.Contains(file)) item.Selected = true;

                actualFiles.Add(item);
            }
            var folders = Directory.GetDirectories(currentFolder);
            foreach (var folder in folders)
            {
                var item = new Item(folder) { IsFolder = true, Children = new List<Item>() };
                Populate(folder, item.Children, syncedItems);
                actualFiles.Add(item);
            }
            return actualFiles;
        }
    }
}
