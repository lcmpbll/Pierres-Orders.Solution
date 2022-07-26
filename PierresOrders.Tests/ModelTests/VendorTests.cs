using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresOrders.Models;

namespace PierresOrders.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]//1
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("TestVendor", "Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]//2
    public void GetName_ReturnsName_String()
    {
      string name = "First Vendor";
      Vendor newVendor = new Vendor(name, "vendor");

      string result = newVendor.Name;

      Assert.AreEqual(result, name);
    }
    [TestMethod]//3
    public void GeDescription_ReturnsDescription_String()
    {
      string description = "First Vendor";
      Vendor newVendor = new Vendor("name", description );

      string result = newVendor.Description;

      Assert.AreEqual(result, description);
    }
    [TestMethod]//4
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor newVendor = new Vendor("name", "description");

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_Vendor()
    {
      Vendor newVendor1 = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name2", "description2");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod] //6
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name2", "description2");

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]//7
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Order newOrder = new Order("description", 300, "date", "title");
      List<Order> newList = new List<Order> {newOrder};
      Vendor newVendor = new Vendor("name", "description");
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }


  }
}