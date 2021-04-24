using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UML_Diagram_Designer
{
   public class SaveOrLoad
    {
        public static void SaveFile(string path, string fileData)
        {
            using (StreamWriter saveSW = new StreamWriter(path, false))
            {
                saveSW.WriteLine(fileData);
            }
        }

        public static string OpenFile(string path)
        {
            using (StreamReader openSR = new StreamReader(path))
            {
                return openSR.ReadToEnd();
            }
        }
    }
}

