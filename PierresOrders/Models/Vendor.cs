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
      _instances.Add(this);
      Id = _instances.Count;
      
    }

   public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[0];
    }

  }
}