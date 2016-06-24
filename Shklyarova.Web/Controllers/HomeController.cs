using System.Web.Mvc;

namespace Shklyarova.Web.Controllers
{
    public class HomeController : ShklyarovaControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}