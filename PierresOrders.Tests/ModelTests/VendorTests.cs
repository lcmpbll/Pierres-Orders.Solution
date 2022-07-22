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
      Vendor newVendor = new Vendor("TestVendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }


  }
}