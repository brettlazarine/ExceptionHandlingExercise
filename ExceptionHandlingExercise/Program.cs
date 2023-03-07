using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            //DONE -- First create an char[], it must contain 6 numbers and 3 letters - name it arr
            char[] arr = { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            
            //DONE -- Create a list called numbers that will hold integers
           
            List<int> numbers = new(); // <--- This is shorthand, does not require new List<int>().  The List is still created. *****
            
            //DONE -- Create an string variable with an empty string initializer - name it str
            
            //string str = "";  // Utilized inline .ToString() instead *****
            
            //DONE -- using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            //DONE -- and Exceptions will be thrown 
            //DONE -- Below we will set this up 
            // ------------------------------------------------------------------------------



            //DONE -- TODO START HERE:

            //DONE -- Make a foreach loop to iterate through your character array
            foreach (var item in arr)
            {
                //DONE -- Now create a try catch

                //DONE -- Inside your try block
                //DONE -- set your string variable to each array element in your char[] to .ToString()
                //DONE -- Now, using int.Parse, parse your string variable and store in an int variable
                //DONE -- Then add each int to your list
                try
                {
                    //str = item.ToString(); // Utilized inline .ToString() instead *****

                    numbers.Add(int.Parse(item.ToString()));
                }

                //DONE -- catch your Exception:
                //DONE -- in the scope of your catch you can use the following, 

                //DONE -- Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"Unable to Parse '{item}'");
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
