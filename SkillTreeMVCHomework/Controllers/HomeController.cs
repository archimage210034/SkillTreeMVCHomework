using SkillTreeMVCHomework.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace SkillTreeMVCHomework.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPaymentService _paymentService;

        public HomeController(IPaymentService paymentService)
        {
            this._paymentService = paymentService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewPayment(Payment newPayment)
        {
            if (ModelState.IsValid)
            {
                _paymentService.AddNewPaymentAndSave(newPayment);
            }
            return RedirectToAction("Index");
        }

        public ActionResult NoteFeatureDateValid(string datetime)
        {
            if (datetime == null) return Json("「日期」未輸入", JsonRequestBehavior.AllowGet);
            DateTime intputDateTime;
            bool isConverSuccess = DateTime.TryParseExact(datetime, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out intputDateTime);

            if (!isConverSuccess) return Json("「日期」格式錯誤(yyyy-MM-dd)或不存在", JsonRequestBehavior.AllowGet);

            bool isDateNotAfterToday = intputDateTime <= DateTime.Now;

            return Json(isDateNotAfterToday ? "true" : "「日期」不得大於今天",
                JsonRequestBehavior.AllowGet); ;
        }

        [ChildActionOnly]
        public ActionResult PaymentListChildAction()
        {
            List<Payment> paymentList = _paymentService.GetAllPaymentList();

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