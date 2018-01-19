using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SPGen.FileManager.Models
{
    public class FileTreeNode : TreeNode
    {
        private const string RegExp = @"\w*(\.\w*)*?$";
        private const string RegExpExtension = @"\.(.\w*)$";
        public FileTreeNode(string path, bool isFolder)
        {
            Path = path;
            Hash = path.GetHashCode();
            Text = Regex.Match(path, RegExp, RegexOptions.IgnoreCase).Value;

            IsFolder = isFolder;
            IsSelectedFile = false;
            SetIcon();
        }
        public string Path { get; }
        public int Hash { get; }
        public bool IsSelectedFile { get; set; }
        public bool IsFolder { get; }

        private void SetIcon()
        {
            if (IsFolder)
            {
                ImageKey = Constants.Icons.Folder;
                return;
            }
            var reg = Regex.Match(Text, RegExpExtension, RegexOptions.IgnoreCase);
            var ext = reg.Groups.Count < 2 ? "" : reg.Groups[1].Value;

            switch (ext)
            {
                case Constants.Icons.Css:
                    ImageKey = Constants.Icons.Css;
                    break;
                case Constants.Icons.Dll:
                    ImageKey = Constants.Icons.Dll;
                    break;
                case Constants.Icons.Ico:
                case Constants.Icons.Jpg:
                case Constants.Icons.Png:
                    ImageKey = Constants.Icons.Picture;
                    break;
                default:
                    ImageKey = Constants.Icons.Blanc;
                    break;
            }
        }
    }
}
