using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //implicit casting
            int digit = 5;

            double doublenumber = digit;
            Console.WriteLine(digit);
            Console.WriteLine(doublenumber);

            //explicit casting
            double newvalue = 45.87;
            int intnumber = (int)newvalue;
            Console.WriteLine(intnumber);


        }

        static void Student()
        {
            Console.WriteLine("What is your name?");
            string name= Console.ReadLine();
            Console.WriteLine("Your name is" + name);

            Console.ReadLine();
        }

    }
}
