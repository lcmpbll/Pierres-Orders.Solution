using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresOrders.Models;
using System;

namespace PierresOrders.Tests
{
 
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
      {
        Order.ClearAll();
      }
  
    [TestMethod] //1
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test", 1, "2", "title");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod] //2
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Bread Order";
      Order newOrder = new Order(description, 1, "2", "title");
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
        Order newOrder = new Order(description, 1, "2", "title");
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
        Order newOrder = new Order("BreadOrder", price, "2", "title");
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
        Order newOrder = new Order("BreadOrder", price, "2", "title");
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
        Order newOrder = new Order("Bread Order", 300, date, "title");

        string result = date;

        Assert.AreEqual(result, newOrder.Date);
      }
      [TestMethod]//7
      public void SetDate_ReturnsUpdatedDate_string()
      {
        //Arrange
        string date = "12/22/30";
        Order newOrder = new Order("BreadOrder", 300, date, "title");
        //Act
        string updatedDate = "1/22/33";
        newOrder.Date = updatedDate;
        string result = updatedDate;
        //Assert
        Assert.AreEqual(result, newOrder.Date);
      }
      [TestMethod]//8
      public void GetTitle_ReturnsTitle_String()
      {
        string title = "Mary's Patisserief";
        Order newOrder = new Order("Bread Order", 300, "11/2/22", title);

        string result = title;

        Assert.AreEqual(result, newOrder.Title);
      }
       [TestMethod]//9
      public void SetTitle_ReturnsUpdatedTitle_string()
      {
        //Arrange
        string title = "Mary's Patisserie";
        Order newOrder = new Order("Pastry Order", 300, "11/2/44", title);
        //Act
        string updatedTitle = "Suzie Baker";
        newOrder.Title = updatedTitle;
        string result = updatedTitle;
        //Assert
        Assert.AreEqual(result, newOrder.Title);
      }
      [TestMethod]//10
      public void GetAll_ReturnsEmptyList_OrderList()
      {
        List<Order> newList = new List<Order>{};

        List<Order> result = Order.GetAll();

        CollectionAssert.AreEqual(newList, result);
      }
      [TestMethod]//11
      public void GetAll_ReturnsOrders_OrderList()
      {
        Order newOrder1 = new Order("Bakery Order", 360, "11/23/33", "Dan's Corner Store");
        Order newOrder2 = new Order("Pastry Order", 360, "11/23/33", "Dan's Corner Store");
        List<Order> newList = new List<Order>{newOrder1, newOrder2};

        List<Order> result = Order.GetAll();

        CollectionAssert.AreEqual(newList, result);
      }
      [TestMethod]//12
      public void GetId_OrdersInstantiatedWithAnIdAndGetterReturns_Int()
      {
        Order newOrder1 = new Order("Bakery Order", 360, "11/23/33", "Dan's Corner Store");

        int result = newOrder1.Id;

        Assert.AreEqual(1, result);
      }
      [TestMethod]//13
      public void Find_ReturnsCorrectOrder_Order()
      {
        Order newOrder1 = new Order("Bakery Order", 360, "11/23/33", "Dan's Corner Store");
        Order newOrder2 = new Order("Pastry Order", 360, "11/23/33", "Dan's Corner Store");

        Order result = Order.Find(2);

        Assert.AreEqual(newOrder2, result);

      }


  }
}