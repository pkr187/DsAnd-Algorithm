﻿namespace DsAndStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs \n2.Binary search \n3.Insertion sort \n4.Bubble sort  \n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 2:
                        BinarySearch binarysearch = new BinarySearch();
                        binarysearch.Search(@"C:\Users\accer\Desktop\Bridgelabz\DsAndAlgorithm\DsAndAlgorithm\Word.txt");
                        break;
                    case 3:
                        InsertionSort insertionsort = new InsertionSort();
                        insertionsort.Insertion();
                        break;
                    case 4:
                        BubbleSort bubblesort = new BubbleSort();
                        bubblesort.Sort(@"C:\Users\accer\Desktop\Bridgelabz\DsAndAlgorithm\DsAndAlgorithm\Word.txt");
                        break;
                }
            }
        }
    }
}