using System;
using System.IO;

namespace sample_filestream_streamreader {
    class Program {
        static void Main(string[] args) {

            string path = @"d:\file1.txt";
            StreamReader sr = null;

            try {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

                Console.ReadLine();
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            finally {
                if (sr != null) sr.Close();
            }
        }
    }
}
