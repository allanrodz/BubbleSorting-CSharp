using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSorting1Try
{
    class binarysearch : Program
    {
        public binarysearch(int key = 0)
        {
            checkpoint1:
            Console.WriteLine("What number would you like to find in the array?");
            try
            {
                key = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter an INT number.");
                goto checkpoint1;
            }

            


        }
    }
}
