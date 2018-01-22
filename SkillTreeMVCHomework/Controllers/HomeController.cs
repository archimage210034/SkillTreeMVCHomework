﻿using SkillTreeMVCHomework.Enum;
using SkillTreeMVCHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SkillTreeMVCHomework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult PaymentListChildAction()
        {
            Random random = new Random(0);
            DateTime createDate = DateTime.Now;
            IEnumerable<Payment> paymentList = Enumerable.Repeat(new Payment(), 100).Select(a =>
            {
                createDate = createDate.AddDays(random.Next(0, 3));
                return new Payment()
                {
                    count = random.Next(1, 20) * 100,
                    datetime = createDate,
                    moneyType = (MoneyTypeEnum)(random.Next(1, 3))
                };
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