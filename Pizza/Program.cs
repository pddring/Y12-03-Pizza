using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toppings = new List<string> {
                "Pepperoni", "Margherita", "Ham and pineapple"
            };

            string selection = ChooseFrom(toppings);

            foreach(string item in toppings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"You have chosen {selection}");
        }

        private static string ChooseFrom(List<string> options)
        {

            Console.WriteLine("Please choose one of the following:");
            options.Add("Vegan");

            // repeat until user input is valid
            bool valid = false;
            int chosenPosition = -1;

            while (!valid) {
                // display the options
                for (int i = 0; i < options.Count; i++) 
                {
                    Console.WriteLine($"{i + 1}: {options[i]}");
                }

                // ask for user input
                Console.Write($"Choose a number (1-{options.Count}): ");
                string response = Console.ReadLine();
                
                if(int.TryParse(response, out chosenPosition) &&
                    chosenPosition > 0 &&
                    chosenPosition <= options.Count)
                {
                    valid = true;
                }
            }

            // return a valid response
            return options[chosenPosition - 1];
        }
    }
}
