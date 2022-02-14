using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String s;
            //String answer = "";

            //Console.Write("Enter the string : ");
            //s = Console.ReadLine();

            //Console.Write("\nAll possible strings are : ");
            //Permutation.permute(s, answer);
            //BinarySearch.DispalyBinarySearch();

            //Console.WriteLine("Insertion Sort");
            //String[] arr = { "ABC", "GTSF", "AAKSHD", "KSHS" };
            //int n = arr.Length;
            //// Function to perform sorting
            //InsertionSort.sort(arr, n);
            //// Calling the function to print result
            //InsertionSort.printArraystring(arr, n);

            //Console.WriteLine("Bubble sort Sort");
            //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            //BubbleSort.DisplaybubbleSort(arr);
            //Console.WriteLine("Sorted array");
            //BubbleSort.printArray(arr);

            //Console.WriteLine("Merging Sort");
            //MergingSort ob = new MergingSort();
            //int[] arr = { 12, 11, 13, 5, 6, 7 };
            //Console.WriteLine("Given Array");
            //MergingSort.printArray(arr);
            ////MergingSort ob = new MergingSort();
            //ob.sort(arr, 0, arr.Length - 1);
            //Console.WriteLine("\nSorted array");
            //MergingSort.printArray(arr);

            Console.WriteLine("Anagram");
            string firstString, secondString;
            //Gets words from user.  
            Console.WriteLine("Enter first string");
            firstString = Console.ReadLine();
            Console.WriteLine("Enter second string");
            secondString = Console.ReadLine();
            Anagram anagram = new Anagram();
            anagram.DisplayAnagram(firstString, secondString);
        }
    }
}
