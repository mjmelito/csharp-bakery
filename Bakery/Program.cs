using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main(string[] args)
    {
      // Welcome message and prices
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread: $5 each, or buy 2 get 1 free.");
      Console.WriteLine("Pastries: $2 each, or buy 3 get 1 free.");

      // // Get user input for number of loaves and pastries
      Console.Write("How many loaves of bread would you like? ");
      int breadCount = int.Parse(Console.ReadLine());

      Console.Write("How many pastries would you like? ");
      int pastryCount = int.Parse(Console.ReadLine());

      // // Create instances of the Bread and Pastry classes
      Bread bread = new Bread(breadCount);
      Pastry pastry = new Pastry(pastryCount);

      // // Calculate the total cost of the order
      decimal totalCost = bread.GetCost() + pastry.GetCost();

      // // Display the total cost to the user
      Console.WriteLine($"Your total cost is: ${totalCost}");
      Console.ReadLine();
    }
  }
}