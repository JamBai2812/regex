using System;
using System.IO;
using System.Text.RegularExpressions;
using static System.Text.RegularExpressions.Regex;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var readFile = ReadFile("sample.txt");
            EmailCount(readFile);
            
        }
        private static string ReadFile(string path)
        {
            var readText = File.ReadAllText(path);
            return readText;
        }

        private static void EmailCount(string readText)
        {
            /*
            int counter = 0;
            */

            MatchCollection matches = Regex.Matches(readText, @"@softwire.com");
            Console.WriteLine(matches.Count);

            /*foreach (var match in matches)
            {
            }*/
            
            /*for (int i = 0; i < readText.Length - 13; i++)
            {
                if (readText.(i, 13) == "@softwire.com")
                {
                    counter++;
                }
            }*/
            
        }
    }
}