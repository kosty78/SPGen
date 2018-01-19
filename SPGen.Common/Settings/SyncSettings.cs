using System.IO;
using EnvDTE;
using Newtonsoft.Json;
using SPGen.Common.Extensions;

namespace SPGen.Common.Settings
{
    public class SyncSettings
    {
        private readonly string _jsonSettings;

        public SyncSettings()
        {
            
        }

        public SyncSettings(string json)
        {
            _jsonSettings = json;
        }
        public SyncSettings(DTE dte)
        {
            if (dte == null) return;
            foreach (ProjectItem item in dte.CurrentProject().ProjectItems)
            {
                if (item.Name == "settings.json")
                {
                    using (StreamReader r = new StreamReader(item.FileNames[0]))
                    {
                        _jsonSettings = r.ReadToEnd();
                        break;
                    }
                }
            }


        }

        //General settings
        public string SitecoreUrl { get; set; }
        public string SitecorePath { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public SyncSettings Create()
        {
            return JsonConvert.DeserializeObject<SyncSettings>(_jsonSettings);
        }
    }
}
