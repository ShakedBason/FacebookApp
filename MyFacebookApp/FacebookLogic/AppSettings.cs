using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace FacebookLogic
{
    public sealed class AppSettings
    {
        private static readonly string sr_AppSettingsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.xml");

        private static AppSettings s_Instance;
        private static readonly object sr_LockGetContext = new object();

        private AppSettings()
        {
        }

        internal static AppSettings Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockGetContext)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = newInstance();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private static AppSettings newInstance()
        {
            AppSettings appSettings;

            if (File.Exists(sr_AppSettingsFilePath))
            {
                using (Stream stream = new FileStream(sr_AppSettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }
            else
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }

        public string LastAccessToken { get; set; }

        public bool RememberUser { get; set; }

        public Point ?LastWindowsLocation { get; set; }
        
        public void SaveSettingsToFile()
        {
            using (Stream stream = new FileStream(sr_AppSettingsFilePath, FileMode.Create, FileAccess.ReadWrite))
            {
                XmlSerializer serializer = new XmlSerializer(GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
