using System;
using System.IO;

namespace sample_directory {
    class Program {
        static void Main(string[] args) {

            string path = @"d:\myfolders";

            try {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach(var f in folders) {
                    Console.WriteLine(f);
                }

                Console.WriteLine();

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (var f in files) {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(path + @"\newFolder");

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
