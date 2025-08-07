using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Assignments
    {
        internal void Sum()
        {
            Console.WriteLine(10 + 20);
            Console.WriteLine("helloji");
        }
        internal void FinancialApp()
        {
            int[] transaction = { 200, -150, 340, 500, -100 };
            int sum = 0;
            for (int i = 0; i < transaction.Length; i++)
            {
                sum = sum + transaction[i];
            }
            Console.WriteLine(sum);
        }
        internal void AverageScore()
        {
            float[] score = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum = sum + score[i];
            }
            float avg = sum / score.Length;
            Console.WriteLine(avg);
        }
        internal void Expensive()
        {
            int[] prices = { 1500, 2300, 999, 3200, 1750 };
            int max = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > max)
                {
                    max = prices[i];
                }
            }
            Console.WriteLine(max);
        }
        internal void SearchHistory()
        {
            int[] search = { 101, 202, 303, 404, 505 };
            for (int i = search.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(search[i]);
            }
        }
        internal void Simulation()
        {
            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;
            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] = measurements[i] * factor;
            }
            foreach (int nums in measurements)
            {
                Console.WriteLine(nums);
            }
        }
        internal void Search_Book()
        {
            int[] bookCodes = { 101, 203, 304, 405, 506 };
            int searchCode = 304;
            for (int i = 0; i < bookCodes.Length; i++)
            {
                if (bookCodes[i] == searchCode)
                {
                    Console.WriteLine($"book found at {i}");
                }
            }
        }
        internal void Second_highest()
        {
            int[] grades = { 56, 78, 89, 45, 67 };
            int highest = int.MinValue;
            int secondHighest = int.MinValue;

            foreach (int mark in grades)
            {
                if (mark > highest)
                {
                    secondHighest = highest;
                    highest = mark;
                }
                else if (mark > secondHighest && mark != highest)
                {
                    secondHighest = mark;
                }
            }
            Console.WriteLine($"second highest grade {secondHighest}");
        }
        internal void Non_duplicate()
        {
            int[] ids = { 102, 215, 102, 324, 215 };

            int[] unique = new int[ids.Length]; // extra array to store unique values
            int count = 0;

            for (int i = 0; i < ids.Length; i++)
            {
                bool alreadyExists = false;

                // Check if ids[i] is already in unique[0..count-1]
                for (int j = 0; j < count; j++)
                {
                    if (ids[i] == unique[j])
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                // If not a duplicate, add it to the unique array
                if (!alreadyExists)
                {
                    unique[count] = ids[i];
                    count++;
                }
            }
            Console.WriteLine("Array after removing duplicates:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(unique[i] + " ");
            }

        }
        internal void Common()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 3, 4, 5, 6, 7 };

            Console.WriteLine("Common elements between the two arrays:");

            // Loop through arr1
            for (int i = 0; i < arr1.Length; i++)
            {
                // Loop through arr2
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr1[i] + " ");
                        break; // Break to avoid duplicate printing for same element
                    }
                }
            }
        }





    }
}
