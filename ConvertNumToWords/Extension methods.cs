using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumToWords
{
    public static class Extension_methods
    {
        static string[] one = {"", "one ", "two ", "three ", "four ",
                       "five ", "six ", "seven ", "eight ",
                       "nine ", "ten ", "eleven ", "twelve ",
                       "thirteen ", "fourteen ", "fifteen ",
                       "sixteen ", "seventeen ", "eighteen ",
                       "nineteen "};

        // strings at index 0 and 1 are not used,  
        // they is to make array indexing simple  
        static string[] ten = {"", "", "twenty ", "thirty ", "forty ",
                       "fifty ", "sixty ", "seventy ", "eighty ",
                       "ninety "};
        public static long n = 111;
        


        // n is 1- or 2-digit number  
        public static string numToWords(int n, string s)
        {
            string str = "";

            // if n is more than 19, divide it  
            if (n > 19)
            {
                str += ten[n / 10] + one[n % 10];
            }
            else
            {
                str += one[n];
            }

            // if n is non-zero  
            if (n != 0)
            {
                str += s;
            }

            return str;
        }
        public static string convertToWords(this long n)
        {

            // stores word representation of  
            // given number n  
            string numToWord = "";

            // handles digits at ten millions and  
            // hundred millions places (if any)  
            numToWord += numToWords((int)(n / 10000000),
                                          "crore ");

            // handles digits at hundred thousands  
            // and one millions places (if any)  
            numToWord += numToWords((int)((n / 100000) % 100),
                                                 "lakh ");

            // handles digits at thousands and tens   
            // thousands places (if any)  
            numToWord += numToWords((int)((n / 1000) % 100),
                                           "thousand ");

            // handles digit at hundreds places (if any)  
            numToWord += numToWords((int)((n / 100) % 10),
                                          "hundred ");

            if (n > 100 && n % 100 > 0)
            {
                numToWord += "and ";
            }

            // handles digits at ones and tens  
            // places (if any)  
            numToWord += numToWords((int)(n % 100), "");

            return numToWord;
        }
       
    }
}
