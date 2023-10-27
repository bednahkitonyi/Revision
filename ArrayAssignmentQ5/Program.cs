using System.ComponentModel;
using System;

namespace ArrayAssignmentQ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to accept an array of integers and print the highest number in it
            int[] array = new int[6];
                Console.WriteLine("Please enter numbers");
            for(int i=0; i<array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            int highest=0;
            for(int i=0 ; i<array.Length ; i++)// finding the highest number a given array
            {
                if (highest < array[i])
                {
                    highest = array[i];
                }
               
            }
            Console.WriteLine($"The highest number in the given array is {highest}");

        }
    }
}