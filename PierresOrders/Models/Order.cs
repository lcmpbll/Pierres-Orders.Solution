using System.Collections.Generic;

namespace PierresOrders.Models
{
  public class Order
  {
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public string Title { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};
    

    public Order(string _description, int _price, string _date, string _title)
    {
      Description = _description;
      Price = _price;
      Date =_date;
      Title = _title;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}