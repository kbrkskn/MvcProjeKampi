using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concreate;
using EntityLayer.Concreate;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetAllBL();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]//Sayfada bir butona tıklanıldığında, bir şey post edildiğinde burası çalışacak
        public ActionResult AddCategory(Category p)
        {
            cm.CategoryAddBL(p);
            return RedirectToAction("GetCategoryList");//Ekleme işlemini gerçekleştrdikten sonra tekrardan listelemek için
        }
    }
}