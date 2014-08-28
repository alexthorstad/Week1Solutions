using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //call our Whilelooptest() function
            //WhileLoopTest();

            FlipACoin(10062);
       
            
            
            //keep the console window open
            Console.ReadKey();
        }

        //FUNCTIONS GO HERE
        static void WhileLoopTest()
        { 
            //while loop from 1=>10

            //declare our incrementor
            int i = 1;
            //define the while loop condition
            while (i <= 10) 
            {
                Console.WriteLine(i);
                //make sure to increment i
                i = i + 1;
            }
        }

        static void FlipACoin(int flips) 
        {
            //declaring intergers to hold how
            // many times we've flipped heads or tails
            int countHeads = 0;
            int countTails = 0;

            //create a random number generator
            // to "flip" our coin
            Random rng = new Random();

            //flip the coin as many times as the flips
            // parameter says we should
            for (int i = 0; i < flips; i = i + 1) 
            {
                //flip that coin
                int flip = rng.Next(0, 2);
                if (flip == 0)
                {
                    //it was a tails, increase our counter
                    countTails = countTails + 1;
                }
                else
                {
                    countHeads = countHeads + 1;
                }
            }
            //output the number of heads
            Console.WriteLine("# of Heads: " + countHeads);
            Console.WriteLine("# of Tails: " + countTails);
        }

        //flip a coin until we get X number of heads
        static void FlipForHeads(int numHeads)
        {
            //counts how many heads we've flipped
            int headsFlipped = 0;
            //incrementor for our loop
            int totalFlips = 0;
            //random number generator to "flip" our coin
            Random rng = new Random();


            //do a while loop to flip coins
            // until we have reached the desired
            // number of heads
            while (numHeads != headsFlipped)
            
            //flip a coin
            int flip = rng.Next(0, 2);
            if (flip == 0); 
            {
                //it's a head
                headsFlipped = headsFlipped + 1;
            }
            //add a flip to our total flip count
            totalFlips = totalFlips + 1;
            
        }
        //write the output of how many flips it took
        // to find all the heads
        Console.WriteLine("It took " + totalFlips 
           + " flips to get " + numHeads + " heads");
    }
}
