using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineAccountBook.Models.ViewModels;
using OnlineAccountBook.Models;
using OnlineAccountBook.Repositories;
using PagedList;

namespace OnlineAccountBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountBookService _accountBookService;

        public HomeController()
        {
            var efUnitOfWork = new EFUnitOfWork();
            _accountBookService = new AccountBookService(efUnitOfWork);
        }

        public ActionResult Index()
        {            
            return View();
        }
                
        [ChildActionOnly]
        public ActionResult AccountTableChildAction(int page =1, int pageSize =10)
        {
            int currentPage = page < 1 ? 1 : page;

            var models = _accountBookService.Lookup()
                .OrderBy(d=>d.Date)
                .ToPagedList(currentPage, pageSize);  //分頁
            
            return View(models);
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