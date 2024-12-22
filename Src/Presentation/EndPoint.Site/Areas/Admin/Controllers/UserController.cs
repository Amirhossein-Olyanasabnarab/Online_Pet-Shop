using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Areas.Admin.Controllers;
[Area("Admin")]
public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetAllUsers()
    {
        return View();
    }
}