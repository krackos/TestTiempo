using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestTiempo
{
    public class Palindromo
    {
        public bool Palindrome(string word)
        {
            word = Regex.Replace(word, @"[,:\.\s]?", "").ToLower();
            bool result = word.Reverse().SequenceEqual(word.ToCharArray());
            
            return result;
        }
    }
}
