using System.IO;

namespace GuidUsage
{
    class FileCreator
    {
        public void WriteFile(string path, string text)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(text);
            }
        }
    }
}
