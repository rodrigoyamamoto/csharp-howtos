using System;
using System.IO;

namespace sample_using_block {
    class Program {
        static void Main(string[] args) {

            string path = @"d:\file1.txt";

            try {
                /*
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                */

                // nested usings
                using (FileStream fs = new FileStream(path, FileMode.Open)) {
                    using (StreamReader sr = File.OpenText(path)) {
                        while (!sr.EndOfStream) {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e) {

                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }
    }
}
