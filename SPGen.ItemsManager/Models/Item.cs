namespace SPGen.ItemManager.Models
{
    public class Item
    {
        public Item() { }
        public Item(string path, bool includeChildren)
        {
            Path = path;
            IncludeChildren = includeChildren;
        }
        public string Path { get; set; }
        public bool IncludeChildren { get; set; }
    }
}
