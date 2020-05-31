using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumToWords
{
    public sealed class ConvertNumToWords : IConvertNumToWords
    {
        private static IConvertNumToWords _instance;

        private static readonly object padlock = new object();

         string[] one = {"", "one", "two", "three", "four",
                       "five", "six", "seven", "eight",
                       "nine", "ten ", "eleven", "twelve",
                       "thirteen", "fourteen", "fifteen",
                       "sixteen", "seventeen", "eighteen",
                       "nineteen"};

        // strings at index 0 and 1 are not used,  
        // they is to make array indexing simple  
         string[] ten = {"", "", "twenty ", "thirty ", "forty ",
                       "fifty ", "sixty ", "seventy ", "eighty ",
                       "ninety "};
        
        // singleton design pattern
        private ConvertNumToWords()
        {

        }

        // checks if instance is available or not - follows singleton design pattern
        public static IConvertNumToWords GetInstance()
        {
            //The block inside the lock ensures that only one thread enters this block at any given time.
            lock (padlock){ 
                if (_instance == null)
                {
                    _instance = new ConvertNumToWords();
                    return _instance;
                }
                return _instance; 
          }
            
        }    

        // n is 1  or 2-digit number  
        private string numToWords(int n, string s)
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

        /*
          this function converts number to its equivalent words format
         */
        public string convertToWords(long n)
        {
            try
            {
                if(n < 0)
                {
                    Console.WriteLine("please enter a positive number");
                    return string .Empty;
                }
                // stores word representation of  
                // given number n
                StringBuilder wordsFormat = new StringBuilder();
                if(n == 0)
                {
                    wordsFormat.Append("Zero");
                }
                // handles digits at ten millions and  
                // hundred millions places (if any)  
                wordsFormat.Append( numToWords((int)(n / 10000000),
                                              " crore "));

                // handles digits at hundred thousands  
                // and one millions places (if any)  
                wordsFormat.Append(numToWords((int)((n / 100000) % 100),
                                                     " lakh "));

                // handles digits at thousands and tens   
                // thousands places (if any)  
                wordsFormat.Append(numToWords((int)((n / 1000) % 100),
                                               " thousand "));

                // handles digit at hundreds places (if any)  
                wordsFormat.Append(numToWords((int)((n / 100) % 10),
                                              " hundred "));

                if (n > 100 && n % 100 > 0)
                {
                    wordsFormat.Append("and ");
                }

                // handles digits at ones and tens  
                // places (if any)  
                wordsFormat.Append(numToWords((int)(n % 100), ""));

                return wordsFormat.ToString();
            }
            catch(IndexOutOfRangeException ex)
            {
                throw new IndexOutOfRangeException(ex.Message);
            } 
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            
        }

    }
}

