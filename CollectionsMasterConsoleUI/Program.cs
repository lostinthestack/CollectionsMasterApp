using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var exampleIntArray = new int[50];


            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(exampleIntArray);


            //Print the first number of the array
            Console.WriteLine("-------------------");
            Console.WriteLine("---------First Number of array:------------");
            Console.WriteLine(exampleIntArray[0]);
            Console.WriteLine("-------------------");

            //Print the last number of the array            
            Console.WriteLine("-------------------");
            Console.WriteLine("---------Last Number of array:------------");
            Console.WriteLine(exampleIntArray[exampleIntArray.Length - 1]);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(exampleIntArray);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(exampleIntArray);
            foreach (var num in exampleIntArray)
                Console.WriteLine(num);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(exampleIntArray);

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(exampleIntArray);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(exampleIntArray);
            foreach (var num in exampleIntArray)
                Console.Write($"{num} ");
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var exampleIntList = new List<int>();


            //Print the capacity of the list to the console
            Console.WriteLine($"List capacity is currently:    {exampleIntList.Count}");


            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(exampleIntList);
            

            //Print the new capacity
            Console.WriteLine($"List capacity is currently:    {exampleIntList.Count}");
            

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            NumberChecker(exampleIntList, int.Parse(Console.ReadLine()));
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(exampleIntList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(exampleIntList);
            NumberPrinter(exampleIntList);

            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            exampleIntList.Sort();
            NumberPrinter(exampleIntList);
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var listToArray = exampleIntList.ToArray();


            //Clear the list
            exampleIntList.Clear();
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i]%3 == 0)
                {
                    numbers[i] = 0;
                    Console.WriteLine(numbers[i]);
                }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count - 1; i++)
            {
                if (numberList[i] % 2 != 0)
                    numberList.Remove(numberList[i]);
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            Console.WriteLine(numberList.Contains(searchNumber) ? $"{searchNumber} is present in the list." : $"{searchNumber} is NOT in the list.");
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
                numberList.Add(rng.Next(0, 50));

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rng.Next(0, 50);

        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length -1; i >= 0; i--)
                Console.WriteLine(array[i]);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
