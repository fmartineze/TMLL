using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
        private string folder;
        public Languages LanguagesList;

        public tmll(string folder_name)
        {

            if (Directory.Exists(folder_name))
            {
                folder = folder_name;
                foreach (string ficheros in Directory.GetFiles(folder_name, "*.lang")) //Catalog all language files
                {
                    // insert into a list
                }

            }
        }


    }
}
