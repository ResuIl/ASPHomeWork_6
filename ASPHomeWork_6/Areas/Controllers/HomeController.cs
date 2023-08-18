using Microsoft.AspNetCore.Mvc;

namespace ASPHomeWork_6.Areas.Controllers;

[Area("Admin")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
