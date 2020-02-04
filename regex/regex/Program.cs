using System;
using System.IO;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string readFile = ReadFile("sample.txt");
            EmailCount(readFile);

           
        }
        public static string ReadFile(string path)
        {
            string readText = File.ReadAllText(path);
            return readText;
        }

        public static void EmailCount(string readText)
        {
            int counter = 0;
            
            for (int i = 0; i < readText.Length - 13; i++)
            {
                if (readText.Substring(i, 13) == "@softwire.com")
                {
                    counter++;
                }
            }
            Console.Write(counter);
            
            

            
        }
    }
}