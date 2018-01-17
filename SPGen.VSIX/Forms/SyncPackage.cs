using System.Linq;
using System.Windows.Forms;
using SPGen.VSIX.Forms.Converters;
using SPGen.VSIX.Settings;

namespace SPGen.VSIX.Forms
{
    public partial class SyncPackage : Form
    {
        private readonly Settings.Settings _settings;
        public SyncPackage(Settings.Settings settings)
        {
            _settings = settings;
            InitializeComponent();
        }

        private void SyncPackage_Load(object sender, System.EventArgs e)
        {
            FileManager.FileManager manager = new FileManager.FileManager();
            var items = manager.PopulateFiles(_settings.SyncSettings.SitecorePath, _settings.FileStructureSettings.GetFile(_settings.FileStructureSettings.FilesPath));
            filesTreeView.Nodes.AddRange(items.ToArray().ToTreeNodes());
        }
    }
}
