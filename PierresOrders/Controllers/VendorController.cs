using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresOrders.Models;

namespace PierresOrders.Controllers
{
  public class VendorController : Controller{

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      // List<Vendor> allVendors = Vendor.GetAll();
      return View();
    }

    // [HttpGet("vendors/new")]
    // {
  
    // }
  }
}