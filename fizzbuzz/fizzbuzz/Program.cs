using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop - FizzBuzz(i) pulls from below @ Static Void.

            //create a loop from 1=>35
            for (int i = 1; i <= 35; i++)
            {
                FizzBuzz(i);
            }
            //make the console stay open
            Console.ReadKey();
      
        }
        //Functions go here
        //FizzBuzz() takes in a number
        // and spits out "fizz", "buzz", "fizzbuss" or the number
        static void FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                //# is divisable by 5 & 3
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                //# is divisable by 5
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                //# is divisable by 3
                Console.WriteLine("Buzz");
            }
            else 
            {
                Console.WriteLine(number);
            } 
        }

    }
}
