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
      Order newOrder = new Order("Test", 1, "2");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod] //2
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Bread Order";
      Order newOrder = new Order(description, 1, "2");
      //Act
      string result = newOrder.Description;
      //Assert
      Assert.AreEqual(description, result);
    }
      [TestMethod] //3
      public void SetDescription_SetDescription_String()
      {
        //Arrange
        string description = "Bread Order";
        Order newOrder = new Order(description, 1, "2");
        //Act
        string updatedDescription = "Pastry Order";
        newOrder.Description = updatedDescription;
        string result = newOrder.Description;
        //Assert
        Assert.AreEqual(updatedDescription, result);
      }
      [TestMethod]//4
      public void GetPrice_ReturnsPrice_Int()
      {
        //Arrange
        int price = 300;
        Order newOrder = new Order("BreadOrder", price, "2");
        //Act
        int result = newOrder.Price;
        //Assert
        Assert.AreEqual(price, result);
      }

      [TestMethod]//5
      public void SetPrice_ReturnsUpdatedPrice_Int()
      {
        //Arrange
        int price = 300;
        Order newOrder = new Order("BreadOrder", price, "2");
        //Act
        int updatedPrice = 200;
        newOrder.Price = updatedPrice;
        int result = updatedPrice;
        //Assert
        Assert.AreEqual(result, newOrder.Price);
      }
      [TestMethod]//6
      public void GetDate_ReturnsDate_String()
      {
        string date = "12/01/23";
        Order newOrder = new Order("Bread Order", 300, date);

        string result = date;

        Assert.AreEqual(result, newOrder.Date);
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