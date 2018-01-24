using SkillTreeMVCHomework.Models;
using System.Collections.Generic;
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