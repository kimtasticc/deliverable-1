// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main(string[] args)
    {
        bool morepbjs = false;
        int slices = 0;
        int pbtbsp = 0;
        int jtsp = 0;

        while (morepbjs == false)
        {
            Console.WriteLine("How many people would like a PB&J?");

            int total = int.Parse(Console.ReadLine());

            slices = total * 2;
            pbtbsp = total * 2;
            jtsp = total * 4;

            Console.WriteLine("Okay, you're going to need: " + slices + " slices of bread, " + pbtbsp + " tablespoons of peanut butter, and " + jtsp + " teaspoons of jelly.");

            double totalloaves = slices / 28.00;
            totalloaves = Math.Ceiling(totalloaves);
            double totalpbjars = pbtbsp / 32.00;
            totalpbjars = Math.Ceiling(totalpbjars);
            double totaljellyjars = jtsp / 48.00;
            totaljellyjars = Math.Ceiling(totaljellyjars);

            Console.WriteLine("When you go to the store, make sure you buy: " + totalloaves + " loaves of bread, " + totalpbjars + " jars of peanut butter, and " + totaljellyjars + " jars of jelly. You'll be able to make all the PB&Js you need!");

           //This breaks my rounding equation for some reason. Figure out why
            Console.WriteLine("Do you want to make more PB&Js? Type Yes or y, or press any other key to exit");
            string answer = Console.ReadLine();
            if (answer == "yes" || answer == "y")
            {
                morepbjs = false;
            }

            else
            {
                morepbjs = true;
                Console.WriteLine("Goodbye. Enjoy your sandwhiches!");
            }
        }
    }
}