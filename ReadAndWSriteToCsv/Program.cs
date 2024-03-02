
using TicketAppJed.Enums;

public static class Program
{
    public static void Main()
    {
        //const string fileName = "users.csv";
        ////string newUser = "Fizuli,8521,FALSE,450\n";
        //Console.WriteLine("Name");
        //var Name = Console.ReadLine();
        //Console.WriteLine("Password");
        //var Password = Console.ReadLine();
        //Console.WriteLine("isAdmin");
        //var IsAdmin = Console.ReadLine();
        //Console.WriteLine("Balance");
        //var Balance = Console.ReadLine();
        //var newUser = $"{Name},{Password},{IsAdmin},{Balance}";
        //File.AppendAllText(fileName, newUser);

        //var usersInFile = File.ReadAllLines(fileName);
        //List<UserModel> users = new List<UserModel>();

        //foreach (var user in usersInFile)
        //{
        //    var splitedUser = user.Split(',');

        //        UserModel tempegerUserModel = new UserModel();
        //        tempegerUserModel.Name = splitedUser[0];
        //        tempegerUserModel.Password = splitedUser[1];
        //        tempegerUserModel.IsAdmin = splitedUser[2] == "TRUE" ? true : false;
        //        tempegerUserModel.Balance = decimal.Parse(splitedUser[3]);

        //        users.Add(tempegerUserModel);    
        //}

        //foreach (var user in users)
        //{
        //    //if (user.Name == "Naila")
        //    //{
        //    //    Console.WriteLine($"Hi {user.Name} your balance is {user.Balance}");
        //    //}
        //    Console.WriteLine($"Username: {user.Name} Password: {user.Password} isAdmin: {user.IsAdmin} Balance: {user.Balance}");
        //}
        ////var user2 = users.Where(x => x.Name == "Naila").First();
        ////Console.WriteLine($"Hi {user2.Name} your balance is {user2.Balance}");
        ///


        while (true)
        {
            Console.WriteLine("0.Regiser\n1.Login");
            Console.Write("Write: ");
            int select = int.Parse(Console.ReadLine());

            switch ((MenuStatus)select)
            {
                case MenuStatus.Login:
                    Console.WriteLine("Login");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case MenuStatus.Register:
                    Console.WriteLine("Register");
                    Console.Write("Name: ");
                    var Name = Console.ReadLine();
                    Console.Write("Password: ");
                    var Password = Console.ReadLine();
                    var res = UserService.Register(Name, Password);
                    Console.WriteLine(res);
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

    
        }
    }
}