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
    }
  }
}