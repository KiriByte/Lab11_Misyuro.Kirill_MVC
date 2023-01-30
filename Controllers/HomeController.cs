using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab11_Misyuro.Kirill_MVC.Models;
using Newtonsoft.Json;

namespace Lab11_Misyuro.Kirill_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IWebHostEnvironment web;

    public HomeController(ILogger<HomeController> logger, IWebHostEnvironment web)
    {
        _logger = logger;
        this.web = web;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult First()
    {
        InfoModel info = new InfoModel(Request, web);
        return View(info);
    }

    public IActionResult Second()
    {
        var info = new InfoModel(Request, web);
        ViewData["Message"] = JsonConvert.SerializeObject(info, Formatting.Indented);
        return View();
    }

    public IActionResult Parameters(string name, string surname, int age)
    {
        ViewBag.Name = name;
        ViewBag.Surname = surname;
        ViewBag.Age = age;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}