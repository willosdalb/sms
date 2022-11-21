using Microsoft.AspNetCore.Mvc;

namespace SMS.Web.Areas.Admin.Controllers;

public class Student : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Upsert()
    {
        return View();
    }
}