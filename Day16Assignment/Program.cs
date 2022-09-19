using System.ComponentModel;
using System.Security.Cryptography;

namespace Day16Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number\n1.Anagram program\n2.Binary search\n3.BubbleSort\n4.Insertion sort\n5.Merge Sort\n6.AnagramOR not\n7.prime number between 0-1000\n8.Prime Number Which Is Anagram and Palindrome");
            int opt=Convert.ToInt32(Console.ReadLine());   
            
            switch(opt)
            {
                case 1:
                Anagram.anagram();
                    break;
                case 2:
                    BinarySearch.binarysearch();
                    break;
                case 3:
                    BubbleSort.Bubblesort();
                    break;
                case 4:
                    InsertionSort.Insert();
                    break;
                case 5:
                    MergeSort mergeSort = new MergeSort();
                    mergeSort.Merging();
                   
                    break;
                case 6:
                   Permutations.Anagrametection();
                    break;
                case 7:
                    PrimeNumbersInRange.PrimeNumbersInRange1();
                    break;
                case 8:
                    PrimeNumberWhichIsAnagramandPalindrome.PrimeNumbers();
                    break;

            }
           
        }
    }
}