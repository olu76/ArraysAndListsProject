using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myIntArray = new int[10];

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var myEvenList = new List<int>();
            var myOddList = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
             
               
            for (int j = 0; j < myIntArray.Length; j++)
            {
                if (myIntArray[j] % 2 == 0)
                {
                    myEvenList.Add(myIntArray[j]);
                }
                else
                {
                    myOddList.Add(myIntArray[j]);
                }   
                   

            }
            
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach (var number in myEvenList)
            {
                Console.WriteLine(number);
            }

        }
    }
}
