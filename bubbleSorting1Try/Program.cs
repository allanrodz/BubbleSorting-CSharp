using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSorting1Try
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************Bubble sorting ARRAYS***********\n");
            int arraysize = 0;

        checkpoint1:
            Console.Write("Enter the size of the array: ");

            try
            {
                arraysize = int.Parse(Console.ReadLine());
                if (arraysize <= 1)
                { 
                Console.WriteLine("Invalid array size. For sorting, array size must be greater than 1.");
                goto checkpoint1;
                }
              
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a valid number.\n");
                goto checkpoint1;
            }
            int[] array = new int[arraysize];
            int index = 0;

            Console.WriteLine($"Your array will have {arraysize} elements.\n");
            for (index = 0; index < array.Length; index++)
            {
                checkpoint2:
                Console.Write($"Please add element {index}: ");
                try
                {
                    array[index] = int.Parse(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.WriteLine("Array type INT.Please enter a valid number.\n");
                    goto checkpoint2;
                }
                
            }

            
                
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nOriginal array order: \n");

            for (index = 0; index < array.Length; index++)
            {
                Console.Write($" {array[index]};");
            }
            

            int smaller = 0, counter = 0;
            
            index = 0;

            for (counter = 0; counter <= (array.Length - 1) * array.Length; counter++) 
            {
                if (array[index] > array[(index + 1)])
                {
                    smaller = array[(index + 1)];
                    array[(index + 1)] = array[index];
                    array[index] = smaller;

                }


                index++;
               

                if (index >= array.Length-1)
                {
                    index = 0;

                }


            }


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nNew array order: \n");

            for (index = 0; index < array.Length; index++)
            {
                Console.Write($" {array[index]};");
            }



            //Console.WriteLine("Would you like to perform a binary search? Y or N.");
            //string answeruser = Console.ReadLine().ToLower();

            //if (answeruser == "y")
            //{

            //}

            Console.ReadLine();
        }
    }
}
