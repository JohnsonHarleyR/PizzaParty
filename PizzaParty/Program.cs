using System;
using System.Collections.Generic;

namespace PizzaParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            List<string> pizzaTypes = new List<string> {"Cheese", "Pepperoni", "Hawaiian",
            "Meat Lover's", "Veggie", "Four Cheese", "Pepperoni Bacon", "Chicken Ranch"};
            int numChoices = 3; // how many types of pizza should be chosen.
            List<int> choices = new List<int>();


            // test
            choices = AskFavoritePizza(pizzaTypes, numChoices);
        }




        // this will ask for the person's top 3 types of pizza
        public static List<int> AskFavoritePizza(List<string> types, int numChoices)
        {
            // variables
            List<int> choices = new List<int>();


            Console.WriteLine($"\nPlease choose {numChoices} pizza types:");

            // loop through the types of pizza
            for (int i = 0; i < types.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {types[i]}");
            }

            Console.WriteLine(); // space

            // now ask for 3 types, store results in an array
            for (int i = 0; i < numChoices; i++)
            {
                string temp = "";
                int num = 0;
                bool isInt = false;

                while (!isInt || choices.Contains(num) || num > types.Count || num < 1)
                {
                    Console.Write($"Pizza type #{i + 1}: ");
                    temp = Console.ReadLine(); // get user input

                    // trim temp just in case
                    temp = temp.Trim();

                    // now try to turn temp into an into
                    try
                    {
                        num = Int32.Parse(temp);
                        isInt = true;
                    }
                    catch (Exception) // if it doesn't work, keep looping
                    {
                        //Console.WriteLine("Invalid input.");
                        isInt = false;
                    }

                    // show invalid input if the number is too high, too
                    if (!isInt || num > types.Count || num < 1 || choices.Contains(num))
                        Console.WriteLine("Invalid input.");


                }

                // now that valid input has been found, put it into the list
                choices.Add(num);

            }

            // once all items have been found for the array, return results
            return choices;

        }


    }
}
