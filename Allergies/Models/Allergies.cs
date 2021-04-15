using System;
using System.Collections.Generic;
using System.Linq;

namespace Allergies.Models
{
    public class AllergyScore
    {
      public Dictionary<string, int> Scores = new Dictionary<string, int>() {{"eggs",1}, {"peanuts",2}, {"shellfish",4}, {"strawberries",8}, {"tomatoes",16}, {"chocolate",32}, {"pollen",64}, {"cats",128}};

      public List<string> CheckAllergies(int score)
      {
        List<string> allergiesList = new List<string> {};
        foreach(KeyValuePair<string,int> entry in Scores)
        {
          if (score == entry.Value)
          {
            allergiesList.Add(entry.Key);
          }
        }
        return allergiesList;
      }
    }
}

  //  public string GetAllergyScore(int score)
  //   {
  //     if (score < 1)
  //     {
  //       return string.Empty;
  //     }
  //     else if (score > 255)
  //     {
  //       return "error: please enter valid number less than 256.";
  //     }
  //     else if (score >= 128)
  //     {
  //       return "cats " + GetAllergyScore(score - 128);
  //     }
  //     else if (score >= 64)
  //     {
  //       return "pollen " + GetAllergyScore(score - 64);
  //     }
  //     else if (score >= 32)
  //     {
  //       return "chocolate " + GetAllergyScore(score - 32);
  //     }
  //     else if (score >= 16)
  //     {
  //       return "tomatoes " + GetAllergyScore(score - 16);
  //     }
  //     else if (score >= 8)
  //     {
  //       return "strawberries " + GetAllergyScore(score - 8);
  //     }
  //     else if (score >= 4)
  //     {
  //       return "shellfish " + GetAllergyScore(score - 4);
  //     }
  //     else if (score >= 2)
  //     {
  //       return "peanuts " + GetAllergyScore(score - 2);
  //     }
  //     else
  //     {
  //       return "eggs.";
  //     }
  //   }


// allergy = (1 + 2 ^ x)
// where x = element of array
// [0,1,2,3,4,5,6]