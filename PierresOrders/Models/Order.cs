namespace PierresOrders.Models
{
  public class Order
  {
    public string Description { get; set; }
    public int Price { get; set; }
    

    public Order(string _description)
    {
      Description = _description;
      Price = 1;
    }
  }
}