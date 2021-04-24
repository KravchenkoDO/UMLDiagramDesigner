using System.IO;

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

