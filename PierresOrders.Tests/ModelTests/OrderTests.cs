using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrders.Models;

namespace PierresOrders.Tests
{
  [TestClass]
  public class OrderTests
  {
    // [TestMethod]
    // public class OrderTests : IDisposable
    // {
    //   public void Dispose()
    //     {
    //       Order.ClearAll();
    //     }
    // }
    [TestMethod] //1
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod] //2
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Bread Order";
      Order newOrder = new Order(description);
      //Act
      string result = newOrder.Description;
      //Assert
      Assert.AreEqual(description, result);
    }
//     [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
  //}
    // [TestMethod]
    // public void ItemConstructor_CreatesInstanceOfItem_Item()
    // {
    //   Item newItem = new Item();
    //   Assert.AreEqual(typeof(Item), newItem.GetType());
    // }

//     [TestMethod]
//     public void GetDescription_ReturnsDescription_String()
//     {
//       string description = "Walk the dog.";
//       Item newItem = new Item(description);
//       string result = newItem.Description;
//       Assert.AreEqual(description, result);
//     }

//     [TestMethod]
// public void GetDescription_ReturnsDescription_String()
// {
//   //Arrange
//   string description = "Walk the dog.";
//   Item newItem = new Item(description);

//   //Act
//   string result = newItem.Description;

//   //Assert
//   Assert.AreEqual(description, result);
// }

  }
}