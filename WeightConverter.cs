using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Convertor
{
    class WeightConverter
    {
        //Method to display the weight menu
        public static void WeightMenu()
        {
            Console.Clear();
            Console.WriteLine("Weight Converter");
            Console.WriteLine("\n1. Kilograms to Pounds \n2. Pounds to Kilograms \n3. Go Back");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    KilogramsToPounds();
                    break;
                case "2":
                    PoundsToKilograms();
                    break;
                case "3":
                    Program.menu();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        public static void KilogramsToPounds()
        {
            Console.Clear();
            Console.WriteLine("Kilograms To Pounds");
            Console.WriteLine("Enter the weight in Kilograms: ");
            double kilograms = Convert.ToDouble(Console.ReadLine()); //Gets the weight in Kilograms from the user

            double pounds = kilograms * 2.205; //Mathical sum to convert Kilograms to Pounds

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kilograms " + kilograms + "kg in Pounds is: " + pounds + "lbs"); //Displays the converted weight
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n1. Go back \n2. Exit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Program.menu();
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exiting...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        public static void PoundsToKilograms()
        {
            Console.Clear();
            Console.WriteLine("Pounds To Kilograms");
            Console.WriteLine("Enter the weight in Pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine()); //Gets the weight in Pounds from the user

            double kilograms = pounds / 2.205; //Mathical sum to convert Pounds to Kilograms

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pounds " + pounds + "lbs in Kilograms is: " + kilograms + "kg"); //Displays the converted weight
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n1. Go back \n2. Exit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Program.menu();
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exiting...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
