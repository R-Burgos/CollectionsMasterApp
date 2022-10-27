using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50 - DONE
            int[] numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50 - DONE
            Populater(numbers);

            //TODO: Print the first number of the array - DONE
            Console.WriteLine($"The first index is:{numbers[0]}");
            //TODO: Print the last number of the array - DONE            
            Console.WriteLine($"The last index is:{numbers[49]}");
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists - DONE
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); - DONE
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇) - DONE
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers - DONE
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now - DONE
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List - DONE
            List<int> intList = new List<int>();

            //TODO: Print the capacity of the list to the console - DONE
            Console.WriteLine("Initial Capacity:");
            Console.WriteLine(intList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this - DONE   
            Populater(intList);

            //TODO: Print the new capacity - DONE
            Console.WriteLine("New Capacity:");
            Console.WriteLine(intList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list - DONE
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int searchNumber;
            bool condition;
            do
            {
                Console.WriteLine("Please enter an integer to search in the list:");
                condition = int.TryParse(Console.ReadLine(), out searchNumber);

            } while (!condition);
            Console.WriteLine("Thank you.");
            NumberChecker(intList, searchNumber);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists - DONE
            NumberPrinter(intList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results - DONE
            Console.WriteLine("Evens Only!!");
            OddKiller(intList);
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results - DONE
            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable - DONE
            
            var listToArray = intList.ToArray();
            //TODO: Clear the list - DONE
            intList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(i => i % 2 != 0); 
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
           
            if (numberList.Contains(searchNumber)) 
            {
                Console.WriteLine($"{searchNumber} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not in the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                int randomize = rng.Next(50);
                numberList.Add(randomize);
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int randomize = rng.Next(50);
                numbers[i] = randomize;
            }
        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

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
