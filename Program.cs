using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Palindromes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var forward = input.ToLower().Replace(" ", "");
            var cleanforwardCharacters = Regex.Replace(forward, "(?:[^a-z0-9])", "");
            Console.WriteLine(cleanforwardCharacters);
            var reverse = cleanforwardCharacters.ToCharArray();
            
            Array.Reverse(reverse);
            string s = new string(reverse);
            Console.WriteLine(reverse);
            
            Console.WriteLine(cleanforwardCharacters == s ? "true" : "false");
        }
    }
}