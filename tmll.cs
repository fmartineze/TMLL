using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TMLL
{
    class Languages
    {
        public string Id { get; set; }
        public string language_name { get; set; }
        public string filename { get; set; }
        public Languages(string id, string language_name, string filename)
        {
            this.Id = Id;
            this.language_name = language_name;
            this.filename = filename;
        }
    }

    class tmll
    {
        public List<Languages> LanguagesList;

        // Constructors
        public tmll(string folder_name)
        {
            LanguagesList = new List<Languages>();
            if (Directory.Exists(folder_name))
            {
                foreach (string ficheros in Directory.GetFiles(folder_name, "*.lang"))
                {
                    if (IniReadValue("info", "language", ficheros) != "")
                    {
                        LanguagesList.Add(new Languages(IniReadValue("info", "id", ficheros), IniReadValue("info", "language", ficheros), ficheros));
                    }
                }
            }
        }


        // Private Metods
        private string IniReadValue(string Section, string Key, string IniPath) // Read from Language FILE as INI Format
        {
            StringBuilder temp = new StringBuilder(255);

            int i = GetPrivateProfileString(Section, Key, "", temp,
                                            255, IniPath);
            return temp.ToString();
        }
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]   // Import Write to INIFILE
        private static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath); // Import Read From INIFILE
    }
}
