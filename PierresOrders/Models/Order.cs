namespace PierresOrders.Models
{
  public class Order
  {
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    

    public Order(string _description, int _price, string _date)
    {
      Description = _description;
      Price = _price;
      Date =_date;
    }
  }
}