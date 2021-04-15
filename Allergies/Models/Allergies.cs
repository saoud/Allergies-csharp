using System;
using System.Collections.Generic;
using System.Linq;

namespace Allergies.Models
{
    public class AllergyScore
    {
      private string[] _Allergens = {"eggs","peanuts","shellfish","strawberries","tomatoes","chocolate","pollen","cats"};

      public List<string> CheckAllergies(int userSum)
      {
        List<string> allergiesList = new List<string> {};
        string sumInBinary = Convert.ToString(userSum, 2);
        string reverseBinary = reverseString(sumInBinary);

        for (int i=0; i < reverseBinary.Length; i++)
        {
          if (reverseBinary[i] == '1')
          {
            allergiesList.Add(_Allergens[i]);
          }
        }
        return allergiesList;
      }

      private static string reverseString(string strToReverse)
      {
        char[] stringToArray = strToReverse.ToCharArray();
        Array.Reverse(stringToArray);
        return String.Join("",stringToArray);
      }
    }
}