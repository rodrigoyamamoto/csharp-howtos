using System;
using System.IO;

namespace samples_csharp {
    class Program {
        static void Main(string[] args) {
            string sourcePath = @"d:\file1.txt";
            string targetPath = @"d:\file2.txt";

            try {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (var line in lines) {
                    Console.WriteLine(line);
                }
                Console.ReadLine();
            }
            catch (IOException e) {

                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
