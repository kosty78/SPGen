using EnvDTE;

namespace SPGen.Common.Settings
{
    public class Settings
    {
        public Settings(DTE dte)
        {
            FileStructureSettings =new FileStructureSettings(dte);
            SyncSettings = new SyncSettings(dte).Create();
        }

        public FileStructureSettings FileStructureSettings { get; }
        public SyncSettings SyncSettings { get; }

    }
}
