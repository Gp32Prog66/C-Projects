using System;
using System.IO;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reads = new StreamReader("Sample.txt");

            using (reads)
            {
                int lineNumber = 0;

                //Read The Line At The Begginning
                string line = reads.ReadLine();

                //Read Other Line from the Text File
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reads.ReadLine();
                }
            }
            //Close
            reads.Close();
        }
    }
}
