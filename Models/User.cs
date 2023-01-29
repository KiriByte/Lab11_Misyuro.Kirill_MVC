namespace Lab11_Misyuro.Kirill_MVC.Models;

public class User
{
    public string name { get; }
    public string surname { get; }
    public string gender { get; }
    public int age { get; }
    
    public User(string name, string surname, string gender, int age)
    {
        this.name = name;
        this.surname = surname;
        this.gender = gender;
        this.age = age;
    }
}