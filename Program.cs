using System;
using System.IO; // Add for file I/O operations

namespace FilesExamplesSDC
{
    class Program
    {
        static void WriteSentences(string fNameParam)
        {
            string nextLine;
            string myFile = fNameParam;

            // Set docPath
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myFile = Path.Combine(docPath, fNameParam);
 
            if (!File.Exists(myFile))  // File does not exist
            {  // create file as it does not exist
                StreamWriter fileStr = File.CreateText(myFile);
            }

            using(StreamWriter fileStr = File.AppendText(myFile))
            { // append to the file
                Console.WriteLine("Enter next sentence: ");
                nextLine = Console.ReadLine();
                if (nextLine != "")
                {
                    fileStr.WriteLine(nextLine);
                }
            } while (nextLine != "") ;

            using (StreamWriter fileStr = File.AppendText(myFile))
            { // close the file
                fileStr.Close();
            }
        }
        static void Main()
        {
            Console.WriteLine("File manipulation");
            WriteSentences("Sentences.txt");
        }
    }
}
