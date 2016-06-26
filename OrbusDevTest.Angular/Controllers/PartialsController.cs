using System.Web.Mvc;

namespace OrbusDevTest.Angular.Controllers
{
    public class PartialsController : Controller
    {
        public ActionResult Index(string partial)
        {
            return PartialView(partial);
        }
    }
}