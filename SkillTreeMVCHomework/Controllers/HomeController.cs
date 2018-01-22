using SkillTreeMVCHomework.Enum;
using SkillTreeMVCHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SkillTreeMVCHomework.Controllers
{
    public class HomeController : Controller
    {
        private SkillTreeHomeworkContent skillTreeHomeworkContent = new SkillTreeHomeworkContent();

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult PaymentListChildAction()
        {
            IEnumerable<Payment> paymentList = skillTreeHomeworkContent.AccountBook
                .Select(x => new Payment()
                {
                    count = x.Amounttt,
                    datetime = x.Dateee,
                    moneyType = (MoneyTypeEnum)x.Categoryyy + 1
                });

            return View(paymentList);
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