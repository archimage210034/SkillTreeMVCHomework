﻿using SkillTreeMVCHomework.Enum;
using SkillTreeMVCHomework.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SkillTreeMVCHomework.Models
{
    public class PaymentService
    {
        private readonly IRepository<AccountBook> _accountBookRepository;

        public PaymentService()
        {
            SkillTreeHomeworkContent skillTreeHomeworkContent = new SkillTreeHomeworkContent();
            _accountBookRepository = new Repository<AccountBook>(skillTreeHomeworkContent);
        }

        public List<Payment> GetAllPaymentList()
        {
            List<Payment> paymentList = _accountBookRepository.GetAllList()
                .Select(x => new Payment()
                {
                    count = x.Amounttt,
                    datetime = x.Dateee,
                    moneyType = (MoneyTypeEnum)x.Categoryyy + 1
                }).ToList<Payment>();
            return paymentList;
        }
    }
}