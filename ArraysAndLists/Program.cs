using System;
using System.Collections.Generic;
using System.Globalization;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10 - DONE!

            int[] myArray = new int[] { 1, 2, 3, 4, 5, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens" - DONE!
             * Name the other List "odds" - DONE!
             */

            List<int> evens = new List<int>();

            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    evens.Add(myArray[i]);
                }
                else
                {
                    odds.Add(myArray[i]);
                }

                /* Now using foreach or for loops,
                 * display each List of even and odd numbers
                 *
                 * Try to be creative in your display
                 */

            }

            foreach (int i in evens)
            {
                Console.WriteLine($"{i} is an even number");
            }

            foreach (int i in odds)
            {
                Console.WriteLine($"{i} is an odd number");
            }
        }
    }
}
