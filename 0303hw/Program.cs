using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _0303hw
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            string regex = @"a\wb";
            MatchCollection mc = new Regex(regex).Matches("ahb acb aeb aeeb adcb axeb");
            foreach (Match match in mc)
            {
                Console.WriteLine(match.Groups[0].Value);
            }
            #endregion

            Console.WriteLine("-----------------------------------------------");

            #region 2
            regex = @"a\w{2}a";
            mc = new Regex(regex).Matches("aba aca aea abba adca abea");
            foreach (Match match in mc)
            {
                Console.WriteLine(match.Groups[0].Value);
            }
            #endregion

            Console.WriteLine("-----------------------------------------------");

            #region 3
            regex = @"ab\wa";
            mc = new Regex(regex).Matches("aba aca aea abba adca abea");
            foreach (Match match in mc)
            {
                Console.WriteLine(match.Groups[0].Value);
            }
            #endregion

            Console.WriteLine("-----------------------------------------------");

            #region 4
            regex = @"ab+a";
            mc = new Regex(regex).Matches("aa aba abba abbba abca abea");
            foreach (Match match in mc)
            {
                Console.WriteLine(match.Groups[0].Value);
            }
            #endregion

            Console.WriteLine("-----------------------------------------------");

            #region 5
            regex = @"ab*a";
            mc = new Regex(regex).Matches("aa aba abba abbba abca abea");
            foreach (Match match in mc)
            {
                Console.WriteLine(match.Groups[0].Value);
            }
            #endregion

            Console.WriteLine("-----------------------------------------------");

            #region 6
            regex = @"ab?a";
            mc = new Regex(regex).Matches("aa aba abba abbba abca abea");
            foreach (Match match in mc)
            {
                Console.WriteLine(match.Groups[0].Value);
            }
            #endregion

            Console.WriteLine("-----------------------------------------------");

            #region 7
            regex = @"ab*a";
            mc = new Regex(regex).Matches("aa aba abba abbba abca abea");
            foreach (Match match in mc)
            {
                Console.WriteLine(match.Groups[0].Value);
            }
            #endregion

            Console.WriteLine("-----------------------------------------------");

            #region 8
            regex = @"(ab)+";
            mc = new Regex(regex).Matches("ab abab abab abababab abea");
            foreach (Match match in mc)
            {
                Console.WriteLine(match.Groups[0].Value);
            }
            #endregion
        }
    }
}
