using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.Shell.Interop;
using SPGen.FileManager.Models;

namespace SPGen.VSIX.Forms.Converters
{
    public static class FileConverter
    {
        public static TreeNode[] ToTreeNodes(this Item[] files)
        {
            TreeNode node = new TreeNode();
            return Populate(files, node.Nodes);
        }

        private static TreeNode[] Populate(IList<Item> files, TreeNodeCollection nodes)
        {
            foreach (var file in files)
            {
                TreeNode node = new TreeNode { Text = file.Path };
                if (file.IsFolder && file.Children.Count > 0)
                {
                    Populate(file.Children, node.Nodes);
                }
                nodes.Add(node);
            }
            return nodes.Cast<TreeNode>().ToArray(); 
        }
    }
}
