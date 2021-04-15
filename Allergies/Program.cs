using System;
using Allergies.Models;
using System.Collections.Generic;

namespace Allergies
{
  public class Program
  {
    public static void Main()
    {
      AllergyScore allergyCalculator = new AllergyScore();
      Console.WriteLine("Enter your allergy score, and I will tell you what you are allergic to: ");
      int userNum = int.Parse(Console.ReadLine());
      List<string> userAllergies = allergyCalculator.CheckAllergies(userNum);
      Console.WriteLine("Looks like you're allergic to: ");
      foreach (string allergen in userAllergies)
      {
        Console.WriteLine(allergen);
      }
      Continue();
    }
    private static void Continue()
    {
      Console.Write("Would you like to check a different input? Type [y] if yes, [n] if you would like to exit: ");
      string userContinue = Console.ReadLine();
      if (userContinue == "y" || userContinue == "Y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye.");
      }
    }
  }
}