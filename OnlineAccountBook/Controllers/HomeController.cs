using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineAccountBook.Models.ViewModels;
using OnlineAccountBook.Models;
using OnlineAccountBook.Repositories;

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
        public ActionResult AccountTableChildAction()
        {
            #region 模擬資料 (Comment)
            //models.Add(new AccountItemViewModels
            //{
            //    Category = "支出",
            //    Date = new DateTime(2017, 01, 01),
            //    Money = 2000,
            //    Description = "水電",
            //});

            //models.Add(new AccountItemViewModels
            //{
            //    Category = "支出",
            //    Date = new DateTime(2017, 02, 01),
            //    Money = 2500,
            //    Description = "水電",
            //});

            //models.Add(new AccountItemViewModels
            //{
            //    Category = "支出",
            //    Date = new DateTime(2017, 03, 01),
            //    Money = 2200,
            //    Description = "水電",
            //});

            //models.Add(new AccountItemViewModels
            //{
            //    Category = "支出",
            //    Date = new DateTime(2017, 04, 01),
            //    Money = 15000,
            //    Description = "水電",
            //});
            #endregion

            var models = _accountBookService.Lookup();            
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