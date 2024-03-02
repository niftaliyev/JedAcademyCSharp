namespace TicketAppJed.Models;

public class UserModel
{
    public string Name { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
    public decimal Balance { get; set; }
}
