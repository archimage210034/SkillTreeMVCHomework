using SkillTreeMVCHomework.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SkillTreeMVCHomework.Controllers
{
    public class HomeController : Controller
    {
        private PaymentService paymentService = new PaymentService();

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult PaymentListChildAction()
        {
            List<Payment> paymentList = paymentService.GetAllPaymentList();

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