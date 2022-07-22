using System.Collections.Generic;

namespace PierresOrders.Models
{
  public class Vendor
  {
    public string Name { get; set; }

    public Vendor(string _name)
    {
      Name = _name;
    }

  }
}