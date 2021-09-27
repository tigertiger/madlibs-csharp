using Microsoft.AspNetCore.Mvc;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Madlibs() { return View(); }
      {
      MadlibsVariable myMadlibsVariable = new MadlibsVariable();
      myMadlibsVariable.PLACEHOLDER = placeholder;
      return View(myMadlibsVariable);
      }

    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}