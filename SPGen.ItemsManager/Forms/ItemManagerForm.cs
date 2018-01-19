using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPGen.Common.Settings;
using SPGen.ItemManager.Models;
using SPGen.ItemsManager;

namespace SPGen.ItemManager.Forms
{
    public partial class ItemManagerForm : UserControl
    {
        private readonly Settings _settings;
        private IDictionary<int, string> _filesToSync;
        private SyncManager _manager;
        public ItemManagerForm(Settings settings)
        {
            InitializeComponent();
            _settings = settings;
            saveBtn.Enabled = false;
        }

        public async Task LoadData()
        {
            try
            {
                _manager = new SyncManager();
                itemsTreeView.ImageList = imageList;
               // itemsTreeView.Nodes.AddRange(_manager.PopulateItems(null, null,out null));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {

            if (itemsTreeView.SelectedNode != null)
            {
                var node = (ItemTreeNode)itemsTreeView.SelectedNode;
                if (node.IsFolder || node.IsSelectedFile) return;

                node.BackColor = Constants.SelectedFile;
                node.IsSelectedFile = true;

                if (!_filesToSync.ContainsKey(node.Hash))
                {
                    _filesToSync.Add(new KeyValuePair<int, string>(node.Hash, node.Path));
                    saveBtn.Enabled = true;
                }
            }
        }
        private void addChildBtn_Click(object sender, EventArgs e)
        {

        }
        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            if (itemsTreeView.SelectedNode != null)
            {
                var node = (ItemTreeNode)itemsTreeView.SelectedNode;
                if (node.IsFolder || !node.IsSelectedFile) return;

                node.BackColor = Constants.UnSelectedFile;
                node.IsSelectedFile = false;

                if (_filesToSync.ContainsKey(node.Hash))
                {
                    _filesToSync.Remove(node.Hash);
                    saveBtn.Enabled = true;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _manager.SaveToFile(null,"");
            saveBtn.Enabled = false;
        }


    }
}
