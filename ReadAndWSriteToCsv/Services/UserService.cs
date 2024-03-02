

namespace TicketAppJed.Services;

public static class UserService
{
    public static bool Register(string Name, string Password)
    {
        if (Name == "" || Password == "")
            return false;

        const string fileName = "users.csv";

        var users = ReadFileService.ReadUsersInFile(fileName);

        foreach (var user in users)
        {
            if (user.Name == Name)
                return false;
        }

        string newUser = $"{Name},{Password},FALSE,0\n";
        File.AppendAllText(fileName, newUser);
        return true;
    }
}
