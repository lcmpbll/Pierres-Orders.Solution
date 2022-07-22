using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresOrders.Models;

namespace PierresOrders.Tests
{
  [TestClass]
  public class VendorTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   Vendor.ClearAll();
    // }

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


  }
}