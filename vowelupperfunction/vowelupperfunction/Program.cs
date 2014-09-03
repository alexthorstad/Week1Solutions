using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelupperfunction
{
    class Program
    {
        // declare a global variable to hold the total number of loops executed
        static int loopCount = 0;

        static void Main(string[] args)
        {
            //call the stringbuilding function
            StringBuilding("a brown fox jumped over the brown fence to watch the who meet the Dr.");
            //print out the number of loops performed
            Console.WriteLine(loopCount);

            //Call our ListPractice() function
            ListPractice

            //call the stringbuilding function to do more loops
            StringBuilding("running a few more loops");


            //building a strong.  Take in a string, and output a string with all vowels uppercase, and all consonants lowercase.
           

            }

        static void StringBuilding(string input)
        {
            //declare a string to hold our output
            string output = "";

            //loop over the input, to compare each letter
            for (int i = 0; i < input.Length; i++)
            {
                //get a letter from the input
                string letter = input[i].ToString();

                //determine if the letter is a vowel
                string vowels = "aeiou";
                if (vowels.Contains(letter.ToLower()))
                {
                    //it is a vowel
                    output = output + letter.ToUpper();
                }
                else
                {
                    //its not a vowel.  ad it a lowercase letter to our output
                    output = output + letter.ToLower();
                }

                //we did a looop, hooray! Add one to the loop counter
                loopCount = loopCount + 1;

            }
            //print the output
            Console.WriteLine(output);



        }

        //working with LISTS
        static void ListPractice()
        {
            //declare a new list
            List<string> sportsList = new List<string>() { "Baseball", "Basketball", "Badmitton", "La Crosse", "Luge", "Curling" };

            //print out the contents of sportsList using a for loop
            // in ascending order
            for (int i = 0; i < sportsList.Count; i++)
            {
                Console.WriteLine(sportsList[i]);
                //we did a loop, count it on the loopCount global 
                loopCount++;
            }

            //print out the contents of sportsList using for loops in reverse order
            //Things to Note: .Count -1, >= 0
            for (int i = sportsList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(sportsList[i]);
                //we did a loop, count it on the loopCount global 
                loopCount++;
            }

            //list out the contents of the sportsList using a foreach loop
            foreach (var item in sportsList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
