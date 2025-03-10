using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Convertor
{
    class TemperatureConverter
    {
        //Method to display the temperature converter menu
        public static void TemperatureMenu()
        {
            Console.Clear();
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("\n1. Celsius to Fahrenheit \n2. Fahrenheit to Celsius \n3. Go Back");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CelsiusToFahrenheit();
                    break;
                case "2":
                    FahrenheitToCelsius();
                    break;
                case "3":
                    Program.menu();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        //Method to convert Fahrenheit to Celsius
        public static void CelsiusToFahrenheit()
        {
            Console.Clear();
            Console.WriteLine("Celsius to Fahrenheit");
            Console.WriteLine("Enter the temperature in Celsius: "); //Gets the temperature in Celsius from the user
            int celsius = Convert.ToInt32(Console.ReadLine());

            int farhenheit = celsius * 9 / 5 + 32; //Mathical sum to convert Celsius to Fahrenheit

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Celsius " + celsius + "°C in Fahrenheit is: " + farhenheit + "°F"); //Displays the converted temperature
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n1. Go back \n2. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Program.menu(); //Calls the menu method
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exiting...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0); //Exits the program
                    break;
                default:
                    Console.WriteLine("Invalid choice"); //Display invalid choice if the user enters a number that is not 1 or 2
                    break;
            }
        }

        //Method to convert Celsius to Fahrenheit
        public static void FahrenheitToCelsius()
        {
            Console.Clear();
            Console.WriteLine("Fahrenheit to Celsius");
            Console.WriteLine("Enter the temperature in Fahrenheit: "); //Gets the temperature in Fahrenheit from the user
            int farhenheit = Convert.ToInt32(Console.ReadLine());

            int celsius = farhenheit - 32 * 5 / 9; //Mathical sum to convert Fahrenheit to Celsius

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Fahrenheit " + farhenheit + "°F in Celsius is: " + celsius + "°C"); //Displays the converted temperature
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n1. Go back \n2. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Program.menu(); //Calls the menu method
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exiting...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0); //Exits the program
                    break;
                default:
                    Console.WriteLine("Invalid choice"); //Display invalid choice if the user enters a number that is not 1 or 2
                    break;
            }
        }
    }
}
