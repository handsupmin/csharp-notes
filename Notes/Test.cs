using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Test
    {
        public static void test()
        {
            string stringTester = "Hello, Good Morning!";
            // IndexOf()
            WriteLine($"IndexOf 'Good' : {stringTester.IndexOf("Good")}"); // 7
            WriteLine($"IndexOf 'o' : {stringTester.IndexOf("o")}"); // 4
            // LastIndexOf()
            WriteLine($"LastIndexOf 'Good' : {stringTester.LastIndexOf("Good")}"); // 7
            WriteLine($"LastIndexOf 'o' : {stringTester.LastIndexOf("o")}"); // 13
            // StartsWith()
            WriteLine($"StartsWith 'Hello' : {stringTester.StartsWith("Hello")}"); // True
            WriteLine($"StartsWith 'Good' : {stringTester.StartsWith("Good")}"); // False
            // EndsWith()
            WriteLine($"EndsWith 'Morning!' : {stringTester.EndsWith("Morning!")}"); // True
            WriteLine($"EndsWith 'Good' : {stringTester.EndsWith("Good")}"); // False
            // Contains()
            WriteLine($"Contains 'Good' : {stringTester.Contains("Good")}"); // True
            WriteLine($"Contains 'o' : {stringTester.Contains("Nice")}"); // False
            // Replace()
            WriteLine($"Replace 'Good' : {stringTester.Replace("Good", "Great")}"); // Good -> Great
        }
    }
}
