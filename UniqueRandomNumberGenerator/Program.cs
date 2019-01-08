

/**
 * Project Name : Unique Random Number Generator'
 * 
 * File Name : UniqueRNG
 * 
 * Creator : Hanbing Wang
 * 
 * Date : Jan 8, 2019
 * 
 * Description :  a program that generates a list of 
 * 10,000 numbers in random order each time it is run.
 * Each number in the list must be unique and be 
 * between 1 and 10,000 (inclusive).
 */

using System;
using System.Collections;
using System.Collections.Generic;
namespace UniqueRandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A program that generates a list of 10,000 numbers in " +
                "random order each time it is run. Each number in the list must be uniqu" +
                "e and be between 1 and 10,000 (inclusive).");
            GenerateNumbers(10000, 1, 10000);
            Console.ReadKey();
        }

        // This function takes the size of random unique numbers that needs to be generated, 
        //the range of the random unique numbers by min and max (inclusively). Then print out the result.
        public static void GenerateNumbers(int size, int min, int max)
        {
            //Handle illegal inputs
            if (size <= 0) return;
            if (min > max) return;

            //Use HashSet to make sure the generated random numbers is unuque
            HashSet<int> uniqueNumbers = new HashSet<int>();
            Random randomNumber = new Random();
            ArrayList res = new ArrayList();

            while (size > 0)
            {
                int rand = randomNumber.Next(min, max + 1);
                // If generated number is unique, add the number to the result
                if (uniqueNumbers.Add(rand))
                {
                    size--;
                    res.Add(rand);
                }
            }
            foreach (var item in res)
            {
                Console.Write(" " + item);
            }
            return;
        }
    }
}
