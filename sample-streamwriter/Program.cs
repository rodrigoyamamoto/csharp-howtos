using System;
using System.IO;

namespace sample_streamwriter {
    class Program {
        static void Main(string[] args) {

            string sourcePath = @"d:\file1.txt";
            string targetPath = @"d:\file2.txt";

            try {
                string[] lines = File.ReadAllLines(sourcePath);

                using(StreamWriter sw = File.AppendText(targetPath)) {
                    foreach (var line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
