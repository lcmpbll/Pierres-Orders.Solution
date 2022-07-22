using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace PierresOrders.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
     
      return View();
    }

  }
}