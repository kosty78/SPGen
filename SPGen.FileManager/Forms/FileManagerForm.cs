using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPGen.FileManager.Models;

namespace SPGen.FileManager.Forms
{
    public partial class FileManagerForm : UserControl
    {
        private readonly string _filesFolder;
        private readonly string _syncFile;
        private IDictionary<int, string> _filesToSync;
        private SyncManager _manager;
        public FileManagerForm(string folder, string syncFile)
        {
            InitializeComponent();
            _filesFolder = folder;
            _syncFile = syncFile;
            saveBtn.Enabled = false;
        }

        public async Task LoadData()
        {
            try
            {    
                _manager = new SyncManager();
                filesTreeView.ImageList = imageList;
                filesTreeView.Nodes.AddRange(_manager.PopulateFiles(_filesFolder, _syncFile, out _filesToSync));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addFileBtn_Click(object sender, EventArgs e)
        {
            if (filesTreeView.SelectedNode != null)
            {
                var node = (FileTreeNode)filesTreeView.SelectedNode;
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

        private void removeFileBtn_Click(object sender, EventArgs e)
        {
            if (filesTreeView.SelectedNode != null)
            {
                var node = (FileTreeNode)filesTreeView.SelectedNode;
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
            Cursor.Current = Cursors.WaitCursor;
            _manager.SaveToFile(_filesToSync, _syncFile);
            Cursor.Current = Cursors.Arrow;
        }

    }
}
