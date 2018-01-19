using System.Threading.Tasks;
using System.Windows.Forms;
using SPGen.Common.Settings;
using SPGen.FileManager.Forms;
using SPGen.ItemManager.Forms;

namespace SPGen.VSIX.Forms
{
    public partial class SyncPackage : Form
    {
        private readonly Settings _settings;
        public SyncPackage(Settings settings)
        {
            _settings = settings;
            InitializeComponent();
        }

        private async void SyncPackage_Load(object sender, System.EventArgs e)
        {
            ItemManagerForm itemManagerForm = new ItemManagerForm(_settings);
            Task im = itemManagerForm.LoadData();

            FileManagerForm fileManagerForm = new FileManagerForm(_settings);
            Task flm = fileManagerForm.LoadData();

            itemManagerForm.Dock = DockStyle.Fill;
            fileManagerForm.Dock = DockStyle.Fill;

            await Task.WhenAll(im, flm);

            syncItemsTab.Controls.Add(itemManagerForm);
            syncFilesTab.Controls.Add(fileManagerForm);
            
        }
    }
}
