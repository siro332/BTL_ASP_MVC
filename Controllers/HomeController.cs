using System;
using System.Web.Mvc;
using BTL_Mvc.Respository.ImpRespository;

namespace BTL_Mvc.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TopSaleProducts()
        {
            ProductRespository productRespository = new ProductRespository();

            return PartialView("~/Views/Home/TopSaleProducts.cshtml", productRespository.findAll());
        }
        public ActionResult NewProductsByCat(String id = null)
        {
            ProductRespository productRespository = new ProductRespository();
            return PartialView("~/Views/Home/NewProductsByCat.cshtml", productRespository.findNewProductsByCat("MLH01"));
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Store()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}