using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}