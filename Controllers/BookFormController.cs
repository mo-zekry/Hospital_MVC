using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
  public class BookFormController : Controller
  {

    public IActionResult Index()
    {
      return View();
    }
  }
}