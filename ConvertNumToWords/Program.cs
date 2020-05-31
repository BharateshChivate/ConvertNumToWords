using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumToWords
{
    /* C# program to print a given number in words.  
The program handles till 9 digits numbers and  
can be easily extended to 20 digit number */
    using System;
    class Program 
    { 
         static void Main()
        {
            // long handles upto 9 digit no  
            // change to unsigned long long int to  
            // handle more digit number  
            Console.WriteLine("Please Enter a positive number");           
            
            long num = long.Parse(Console.ReadLine());

            //singleton pattern
            IConvertNumToWords c1 = ConvertNumToWords.GetInstance();
            //Console.WriteLine(c1.convertToWords(n1));           
            Console.WriteLine(c1.convertToWords(num));  

            //Implemenet using extension methods for long type
            // Console.WriteLine(n1.convertToWords());
            // convert given number in words  
            Console.WriteLine("Press any key to exist.");
            Console.ReadLine();
        }
    }    
}
