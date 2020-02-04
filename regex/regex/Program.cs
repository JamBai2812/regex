using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            var matches = EmailCount(readFile);
            EmailDictionary(matches);
        }
        
        private static string ReadFile(string path)
        {
            var readText = File.ReadAllText(path);
            return readText;
        }

        private static MatchCollection EmailCount(string readText)
        {
            MatchCollection matches = Regex.Matches(readText, @"@\w+\.\w+\.\w+|@\w+\.\w+");
            
            return matches;
        }

        private static void EmailDictionary(MatchCollection matches)

        {
            Dictionary<string, int> emailDictionary = new Dictionary<string, int>();
    
            foreach (Match domain in matches)
            {

                if (emailDictionary.ContainsKey(domain.ToString()))
                {
                    emailDictionary[domain.ToString()]++;
                }
                else
                {
                    emailDictionary.Add(domain.ToString(), 1);
                }
            }

            foreach (var (key, value) in emailDictionary)
            {
                Console.WriteLine($"domain: {key}, count: {value}");
            }
            
        }
    }
}