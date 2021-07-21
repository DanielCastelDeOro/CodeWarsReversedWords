using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using System.Globalization;

namespace CodeWarsReversedWords
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("world! hello", Kata.ReverseWords("hello world!"));
            Assert.AreEqual("this like speak doesn't yoda", Kata.ReverseWords("yoda doesn't speak like this"));
            Assert.AreEqual("foobar", Kata.ReverseWords("foobar"));
            Assert.AreEqual("kata editor", Kata.ReverseWords("editor kata"));
            Assert.AreEqual("boat your row row row", Kata.ReverseWords("row row row your boat"));
        }
    }
    //Complete the solution so that it reverses all of the words within the string passed in.
    public class Kata
    {
        public static string ReverseWords(string str)
        {

            return string.Join(" ", str.Split(' ').Reverse());
           
        }
    }
}
