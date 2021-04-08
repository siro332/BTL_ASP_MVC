using System.Linq;
using System.Web.Mvc;
using BTL_Mvc.Respository.ImpRespository;

namespace BTL_Mvc.Controllers
{
    public class RenderLayoutController : Controller
    {
        // GET: RenderLayout
        public ActionResult LoadHeader()
        {
            CategoriesRepository categories = new CategoriesRepository();
            return PartialView("~/Views/Shared/_Header.cshtml", categories.findAll().Take(5));
        }
    }
}