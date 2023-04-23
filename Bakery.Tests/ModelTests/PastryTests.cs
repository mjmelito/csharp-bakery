using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
        public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
        {
            Pastry newPastry = new Pastry(1);
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }

    [TestMethod]
        public void GetBreadCount_ReturnsBreadCount_Int()
        {
            int pastryCount = 3;
            Pastry newPastry = new Pastry(pastryCount);
            int result = newPastry.PastryCount;
            Assert.AreEqual(pastryCount, result);
        }
  }
}