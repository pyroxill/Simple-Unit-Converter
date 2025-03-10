using System.ComponentModel.Design;

namespace Unit_Convertor
//Author: Jayden Robertson
//Date: 10/03/2025
//Description: A simple unit converter that converts temperature and weight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu(); //Calls the menu method
        }

        //Method to display the main menu
        public static void menu() {
            Console.WriteLine("Unit Converter");
            Console.WriteLine("\n1. Temperature: \n2. Weight: \n3. Exit");
            String choice = Console.ReadLine();

            //Switch statement to choose which converter to use or exit the program
            switch (choice)
            {
                case "1":
                    TemperatureConverter.TemperatureMenu(); //Calls the TemperatureConvert method from the TemperatureConverter class
                    break;
                case "2":
                    WeightConverter.WeightMenu(); 
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exiting...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0); //Exits the program
                    break;
                default:
                    Console.WriteLine("Invalid choice"); //Displays invalid choice if the user enters a number that is not 1, 2 or 3
                    break;
            }
        }
    }
}
