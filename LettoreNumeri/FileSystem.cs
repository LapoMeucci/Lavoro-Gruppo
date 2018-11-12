using System.IO;

namespace LettoreNumeri
{
    public static class FileSystem
    {
        public static void write (string path, string data)
        {
            File.WriteAllText(@path, data);
        }

        public static string readFile (string path)
        {
            return File.ReadAllText(@path);
        }
    }
}