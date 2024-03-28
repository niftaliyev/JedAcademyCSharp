
using Exceptions.Models;

Random rand = new Random();


List<Product> products = new List<Product>() { new Product
                                    {
                                        Category = Category.Pizza,
                                        Description = "Pepperoni, Dilim Sucuk, Mal Əti Vetçinası, Sosiska, Göbələk, Yaşıl Bibər, Qara Zeytun, Qarğıdalı, Pomidor, Küncüt, Kəklikotu, Pizza Sousu, Mozzarella Pendiri",
                                        Price = 20.40,
                                        Title = "Supreme",
                                        Id = 1
                                    },
                                            new Product
                                    {
                                        Category = Category.Pizza,
                                        Description = "Çeddar Pendiri, Feta Pendiri, Parmesan Pendiri, Pizza Sousu, Mozzarella Pendiri",
                                        Price = 12.40,
                                        Title = "4 Pendirli",
                                        Id = 2
                                    },
                                    new Product
                                    {
                                        Category = Category.Drink,
                                        Description = "500ml",
                                        Price = 1.40,
                                        Title = "Coca-Cola",
                                        Id = 3
                                    },new Product
                                    {
                                        Category = Category.Drink,
                                        Description = "300ml",
                                        Price = 1.50,
                                        Title = "Sprite",
                                        Id = 4
                                    }};


var drink = products.Where(product => product.Category == Category.Drink && product.Price > 1.40).FirstOrDefault();
var pizza = products.Where(product => product.Category == Category.Pizza).FirstOrDefault();


Cart cart = new Cart();

Order order1 = new Order { Product = drink, Count = 3 };

Order order2 = new Order { Product = pizza, Count = 3 };

cart.Orders.Add(order1);
cart.Orders.Add(order2);

cart.TotalPrice = cart.Orders.Select(x => x.Count * x.Product.Price).Sum();

foreach (var item in cart.Orders)
{
    Console.WriteLine($"\n{item.Product}\nCount: {item.Count}\n TotalPrice: {Math.Round(item.Product.Price * item.Count,3)}");
}


Console.WriteLine();Console.WriteLine();Console.WriteLine();

Console.WriteLine($"Total Price: {Math.Round(cart.TotalPrice,3)}");