using System;
using System.IO; // Add for file I/O operations

namespace FilesExamplesSDC
{
    class Program
    {
        static void WriteSentences()
        {
            string nextLine;
            string myFile = "sentences.txt";

            // Version 1
            // StreamWriter fileStr = File.CreateText(myFile);

            // Version 2 write to My Documents
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myFile = Path.Combine(docPath, myFile);
            StreamWriter fileStr = File.CreateText(myFile);

            do
            {
                Console.WriteLine("Enter next sentence: ");
                nextLine = Console.ReadLine();
                if (nextLine != "")
                {
                    fileStr.WriteLine(nextLine);
                }
            } while (nextLine != "");
            fileStr.Close();
        }
        static void Main()
        {
            Console.WriteLine("File manipulation");
            WriteSentences();
        }
    }
}
