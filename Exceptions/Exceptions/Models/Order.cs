namespace Exceptions.Models;

public class Order
{
    public Product Product { get; set; }
    public int Count { get; set; }
    public double Price { get; set; }
}
