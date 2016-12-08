using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTiempo;

namespace UnitTiempo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Palindromo()
        {
            string word = "Radar";
            string word_name = "aNna";
            string word_madam = "madam";
            string word_long = "A man, a plan, a canal: Panama.";
            Palindromo palindromo = new Palindromo();

            bool methodReturn = palindromo.Palindrome(word);
            bool methodReturn_name = palindromo.Palindrome(word_name);
            bool methodReturn_madame = palindromo.Palindrome(word_madam);
            bool methodReturn_long = palindromo.Palindrome(word_long);

            Assert.IsTrue(methodReturn);
            Assert.IsTrue(methodReturn_name);
            Assert.IsTrue(methodReturn_madame);
            Assert.IsTrue(methodReturn_long);
        }
        [TestMethod]
        public void False_Palindromo()
        {
            string word = "word";
            string word_notA = "not a palindrome";
            Palindromo palindromo = new Palindromo();

            bool methodReturn = palindromo.Palindrome(word);
            bool methodReturnNotA = palindromo.Palindrome(word_notA);

            Assert.IsFalse(methodReturn);
            Assert.IsFalse(methodReturnNotA);
        }
    }
}
