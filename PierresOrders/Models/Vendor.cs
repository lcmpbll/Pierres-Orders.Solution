using System.Collections.Generic;

namespace PierresOrders.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    

    public Vendor(string _name, string _description)
    {
      Name = _name;
      Description = _description;
      Id = 3;
    }

  }
}