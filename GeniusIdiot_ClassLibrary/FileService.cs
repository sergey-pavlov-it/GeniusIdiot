using System.Text;

namespace GeniusIdiot.Infrastructure
{
    public class FileService
    {
        public void EnsureFileExists(string path)
        {
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate)) { }
        }

        public void AppendLine(string path, string line)
        {
            using (StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8))
            {
                writer.WriteLine(line);
            }
        }

        public string[] ReadLines(string path)
        {
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                List<string> lines = new List<string>();
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                string[] result = lines.ToArray();
                return result;
            }
        }

        public void OverwriteFile(string path, IEnumerable<string> lines)
        {
            using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
