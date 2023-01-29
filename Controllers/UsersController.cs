using Lab11_Misyuro.Kirill_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab11_Misyuro.Kirill_MVC.Controllers;

public class Users : Controller
{
    static UsersModel listusers = new UsersModel();
    // GET
    public IActionResult Index()
    {

        return View(listusers);
    }

    [HttpGet]
    public IActionResult AddUser(string name, string surname, string gender, int age)
    {
        listusers.AddUser(name, surname, gender, age);
        return RedirectToAction("Index");
    }
}