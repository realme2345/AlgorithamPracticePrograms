using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamProblems
{
    internal class BinarySearch
    {
        public static void DispalyBinarySearch()
        {
            List<string> list1 = new List<string>();

            // List elements
            list1.Add("ABCD");
            list1.Add("QRST");
            list1.Add("XYZ");
            list1.Add("IJKL");


            Console.WriteLine("The Original List is:");
            foreach (string g in list1)
            {
                // prints original List
                Console.WriteLine(g);
            }

            Console.WriteLine("\nThe List in Sorted form");
            // sort the List
            list1.Sort();
            Console.WriteLine();
            foreach (string g in list1)
            {
                // prints the sorted List
                Console.WriteLine(g);
            }
            // find the list contains the word or not
            int index = list1.BinarySearch("ABCD");
            if (index < 0)
            {
                Console.WriteLine("Item is not found");
            }
            else
            {
                Console.WriteLine("The item was found");
            }
        }
    }
}
