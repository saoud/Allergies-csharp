using System;
using System.Collections.Generic;

namespace Allergies.Models
{
    public class AllergyScore
    {
      public Dictionary<string, int> Scores = new Dictionary<string, int>() {{"eggs",1}, {"peanuts",2}, {"shellfish",4}, {"strawberries",8}, {"tomatoes",16}, {"chocolate",32}, {"pollen",64}, {"cats",128}};

      public List<string> CheckAllergies(int score)
      {
        List<string> allergiesList = new List<string> {};
        if (score == 1)
        {
          allergiesList.Add("eggs");
        }
        else
        {
          allergiesList.Add("peanuts");
        }
        return allergiesList;
      }
    }
}