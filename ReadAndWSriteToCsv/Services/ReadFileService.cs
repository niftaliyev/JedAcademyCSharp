namespace TicketAppJed.Services;

public static class ReadFileService
{
    public static List<UserModel> ReadUsersInFile(string fileName)
    {
        List<UserModel> users = new List<UserModel>();

        var file = File.ReadAllLines(fileName);


        foreach (var user in file)
        {
            var splitedUser = user.Split(',');

            UserModel tempegerUserModel = new UserModel();
            tempegerUserModel.Name = splitedUser[0];
            tempegerUserModel.Password = splitedUser[1];
            tempegerUserModel.IsAdmin = splitedUser[2] == "TRUE" ? true : false;
            tempegerUserModel.Balance = decimal.Parse(splitedUser[3]);

            users.Add(tempegerUserModel);
        }

        return users;
    }
}
