using System;
using System.Linq.Expressions;

namespace Deliverable__2_
{
    internal class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter an integer between 5 and 15");
                int input = int.Parse(Console.ReadLine());

                if (input >= 5 && input <= 15)

                {
                    int[] sampleArray = random_array(input);

                    Console.WriteLine("The elements in the random array are: ");
                    foreach (int element in sampleArray)
                    {
                        Console.Write(element + " ");
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + sum(random_array(input)));
                }
                else
                {
                    Console.WriteLine("Please enter a number between 5 and 15");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a integer");
            }

        }
    }
}