namespace Exceptions.Models;

public class Cart
{
    public List<Order> Orders { get; set; } = new List<Order>();

    public double TotalPrice { get; set; } 
}
