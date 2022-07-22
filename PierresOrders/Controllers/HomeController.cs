using Microsoft.AspNetCore.Mvc;
using PierresOrders.Models;

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