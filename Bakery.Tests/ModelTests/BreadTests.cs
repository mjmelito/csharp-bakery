using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
        Bread newBread = new Bread(1);
        Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadCount_ReturnsBreadCount_Int()
    {
        int breadCount = 3;
        Bread newBread = new Bread(breadCount);
        int result = newBread.BreadCount;
        Assert.AreEqual(breadCount, result);
    }

    [TestMethod]
    public void GetBreadCost_ReturnsBreadCost_Decimal()
    {
        int breadCount = 3;
        decimal expectedCost = 10m;
        Bread newBread = new Bread(breadCount);
        decimal actualCost = newBread.GetCost();
        Assert.AreEqual(expectedCost, actualCost);
    }
  }
}