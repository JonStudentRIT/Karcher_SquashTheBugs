using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //Compile-time error, missing semicolon
            //Logical error, the counter is meant to begin at 1
            //Logical error, Integer used to hold Decimal results
            //int i = 0
            float i = 1;

            string allNumbers = null;

            // loop through the numbers 1 through 10
            // Logical error, the counter is being reset in the for loop
            // Logical error, the loop does not cycle 10 times
            //for (i = 1; i < 10; ++i)
            for (int I = 1; I <= 10; ++I)
            {
                // declare string to hold all numbers
                // Logical error, allNumbers is being reset to null in every cycle
                //string allNumbers = null; moved to line 25

                // output explanation of calculation
                // Compile-time error, missing parentheses around math inside a concatenated string
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                // Run-time error, attempt to divide by zero
                //Console.WriteLine(i / (i - 1));
                if (i == 1)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(i / (i - 1));

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                i = i + 1;
                // Compile-time error, "allNumbers" is out of scope
                //} moved to line 62

                // output all numbers which have been processed
                //Compile-time error, the string and variable "allNumbers" requiers concatenation
                //Console.WriteLine("These numbers have been processed: " allNumbers);
                Console.WriteLine("These numbers have been processed: " + allNumbers);
            }
        }
    }
}
