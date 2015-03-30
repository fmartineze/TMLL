using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace TMLL
{
    public class Languages
    {
        public string Id { get; set; }
        public string language_name { get; set; }
        public string filename { get; set; }
        public Languages(string id, string language_name, string filename)
        {
            this.Id = id;
            this.language_name = language_name;
            this.filename = filename;
        }
    }

    class tmll
    {
        public List<Languages> LanguagesList;
        public Languages SelectLanguage;

        // Constructors
        public tmll(string folder_name, string LanguageToSelect = "")
        {
            LanguagesList = new List<Languages>();
            SelectLanguage = new Languages("", "", "");
            if (Directory.Exists(folder_name))
            {
                foreach (string ficheros in Directory.GetFiles(folder_name, "*.lang"))
                {
                    if (IniReadValue("info", "language", ficheros) != "")
                    {
                        LanguagesList.Add(new Languages(IniReadValue("info", "id", ficheros), IniReadValue("info", "language", ficheros), ficheros));
                        if (LanguageToSelect == IniReadValue("info", "id", ficheros))
                        {
                            SelectLanguage.Id = LanguageToSelect;
                            SelectLanguage.language_name = IniReadValue("info", "language", ficheros);
                            SelectLanguage.filename = ficheros;
                        }
                    }
                }

            }
        }

        // Public Metods

        public bool SetActiveLanguage(string IDlanguage) // Change the activa language with ID string
        {
            if (LanguagesList.FindIndex(x => x.Id.Contains(IDlanguage)) >= 0)
            {
                SelectLanguage = LanguagesList.Find(x => x.Id.Contains(IDlanguage));

                return true;
            }
            else { return false; }
        }


        public string ReadWord(string WordTag) // Return string of any WordTag
        {

            return IniReadValue("words", WordTag, SelectLanguage.filename);
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
