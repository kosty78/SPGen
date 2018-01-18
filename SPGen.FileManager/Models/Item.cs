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
    }
}
