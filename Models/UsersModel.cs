namespace Lab11_Misyuro.Kirill_MVC.Models;

public class UsersModel
{
    public List<User> listusers = new List<User>();

    public void AddUser(string name, string surname,string gender, int age)
    {
        listusers.Add(new User(name,surname,gender,age));
    }
}