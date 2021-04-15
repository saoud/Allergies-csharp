using Microsoft.VisualStudio.TestTools.UnitTesting;
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
				Assert.AreEqual("eggs", testAllergyScore.CheckAllergies(1));
			}
    }
}