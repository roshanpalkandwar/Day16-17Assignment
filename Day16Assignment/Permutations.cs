using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Assignment
{
    internal class Permutations
    {
        public static void Anagrametection()
        {
            Console.WriteLine("enter the word 1 and 2");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            //string str1 = "heart";
            //string str2 = "Earth";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            String val1 = new String(ch1);
            String val2 = new String(ch2);

            Console.WriteLine(val1 + "  " + val2);

            if (val1 == val2)
                Console.WriteLine("anagram");
            else
                Console.WriteLine("Not anagram");

        }



    }
}
