using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class File
    {
        public string Name { get; set; }
        public string Folder { get; set; }
        public long Size { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var filesCount = int.Parse(Console.ReadLine());
            var allFiles = new List<File>();
            var matchedFiles = new Dictionary<string, long>();
            for (int i = 0; i < filesCount; i++)
            {
                ReadFile(allFiles);
            }
            PrintFiles(allFiles, matchedFiles);
        }

        private static void PrintFiles(List<File> allFiles, Dictionary<string, long> matchedFiles)
        {
            var tokens = Console.ReadLine().Split().ToArray();
            var fileExtension = tokens[0];
            var rootDirectory = tokens[2];

            foreach (var file in allFiles)
            {
                if (file.Name.EndsWith(fileExtension) && file.Folder.Equals(rootDirectory))
                {
                    matchedFiles[file.Name] = file.Size;
                }
            }
            if (matchedFiles.Count > 0)
            {
                var sortedMatches = matchedFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
                foreach (var match in sortedMatches)
                {
                    Console.WriteLine($"{match.Key} - {match.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static void ReadFile(List<File> allFiles)
        {
            var tokens = Console.ReadLine().Split('\\');
            var fileData = tokens.Last().Split(';');
            var fileName = fileData[0];
            var fileSize = long.Parse(fileData.Last());
            var fileRootFolder = tokens[0];
            allFiles.Add(new File{Folder = fileRootFolder, Name = fileName, Size = fileSize});
        }
    }
}
