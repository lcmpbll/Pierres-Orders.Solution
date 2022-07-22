using System.Collections.Generic;

namespace PierresOrders.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }

    public Vendor(string _name, string _description)
    {
      Name = _name;
      Description = "Baked goods seller";
    }

  }
}