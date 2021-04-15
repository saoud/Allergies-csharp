using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Allergies.Models;

namespace Allergies.Tests
{
	[TestClass]
	public class AllergyScoreTests
	{
		[TestMethod]
		public void CheckAllergies_IfInputIs1_eggs()
		{
			AllergyScore testAllergyScore = new AllergyScore();
			CollectionAssert.AreEqual(new List<string> {"eggs"}, testAllergyScore.CheckAllergies(1));
		}
		[TestMethod]
		public void CheckAllergies_IfInputIs2_peanuts()
		{
			AllergyScore testAllergyScore = new AllergyScore();
			CollectionAssert.AreEqual(new List<string> {"peanuts"}, testAllergyScore.CheckAllergies(2));
		}	
		[TestMethod]
		public void CheckAllergies_IfInputIs4_shellfish()
		{
			AllergyScore testAllergyScore = new AllergyScore();
			CollectionAssert.AreEqual(new List<string> {"shellfish"}, testAllergyScore.CheckAllergies(4));
		}	
		[TestMethod]
		public void CheckAllergies_IfInputIs3_eggspeanuts()
		{
			AllergyScore testAllergyScore = new AllergyScore();
			CollectionAssert.AreEqual(new List<string> {"eggs","peanuts"}, testAllergyScore.CheckAllergies(3));
		}	
	}
}