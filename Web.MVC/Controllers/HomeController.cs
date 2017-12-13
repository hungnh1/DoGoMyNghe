using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnF;
using Web.Repository;
namespace baohiem.Controllers
{
    public class HomeController : Controller
    {
        private DoGoMyNgheEntities db = new DoGoMyNgheEntities();
        public ActionResult Index()
        {
            int lstnewKey1 = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["listNew1"]);
            int lstnewKey2 = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["listNew2"]);

            ViewBag.Slide = db.ADVs.Take(10).ToList();
            ViewBag.listCategory = db.Categories.Where(p=>p.Des=="1").ToList();

            return View();
        }

        public ActionResult Viewhtml()
        {
           
            return View();
        }

        
        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            CustommerOpinion custommerOpinions = new CustommerOpinion();
            custommerOpinions.Email = fc["yourmail"].ToString();
            db.CustommerOpinions.Add(custommerOpinions);
            db.SaveChanges();
            TempData["success"] = "true";
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(db.Pages.First());
        }



        public ActionResult NewsList(int? paging)
        {
            if (paging == null)
            {
                paging = 1;
            }
            return View(db.Pages.OrderBy(p => p.PageId).Skip(paging.Value).Take(5).ToList().OrderByDescending(t => t.PageId).ToList());
        }

        public ActionResult NewsDetail(int? pageId)
        {
            ViewData["ListProduct"] = db.Products.ToList();
            if (pageId == null)
            {              
                var pgeN = db.Pages.ToList().First();
                ViewData["ListPages"] = db.Pages.Where(p => p.ParentId == pgeN.ParentId).ToList();
                return View(pgeN);
            }
 
            var pge = db.Pages.Find(pageId);
            if (pge == null)
            {
                pge = db.Pages.First();
            }

            ViewData["ListPages"] = db.Pages.Where(p => p.ParentId == pge.ParentId).ToList();
            return View(pge);
        }
        public ActionResult ProductDetail(int? detailId)
        {
            ViewData["ListDetail"] = db.Products.ToList();
            return View();
        }
             

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(FormCollection fc)
        {
            var content = fc["fullname"] + " - " + fc["address"] + " - " + fc["email"]
                + " - " + fc["phone"] + ":" + fc["content"];
            MailReponsitory.Mail(fc["email"], content, "Góp ý");
            TempData["suucess"] = "true";
            try
            {
                MailReponsitory.Mail(fc["email"], fc["content"], "Góp ý");
                TempData["suucess"] = "true";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return View("Contact");
        }




    }
}