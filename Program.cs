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

            // Version 1 - write relative to folder the binary is in
            // StreamWriter fileStr = File.CreateText(myFile);

            // Version 2 - Path to My Documents folder
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myFile = Path.Combine(docPath, myFile);
            //StreamWriter fileStr = File.CreateText(myFile);

            // Version 3 - Appending
            StreamWriter fileStr = File.AppendText(myFile);
            
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
