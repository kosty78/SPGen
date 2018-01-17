
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SPGen.FileManager.Models
{
    public class Item
    {
        public Item() { }
        public Item(string path)
        {
            Path = path;
        }
        public string Path { get; set; }

        [JsonIgnore]
        public bool Selected { get; set; }
        [JsonIgnore]
        public bool IsFolder { get; set; }
        [JsonIgnore]
        public IList<Item> Children { get; set; }
    }
}
