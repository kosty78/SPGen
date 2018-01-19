using System.Threading.Tasks;
using System.Windows.Forms;
using SPGen.FileManager.Forms;

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

        private async void SyncPackage_Load(object sender, System.EventArgs e)
        {
            FileManagerForm fileManagerForm = new FileManagerForm(_settings.SyncSettings.SitecorePath, _settings.FileStructureSettings.FilesPath);
            Task flm = fileManagerForm.LoadData();


            await flm;
            fileManagerForm.Dock = DockStyle.Fill;
            syncFilesTab.Controls.Add(fileManagerForm);
            
        }
    }
}
