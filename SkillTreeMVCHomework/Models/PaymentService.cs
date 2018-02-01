using SkillTreeMVCHomework.Enum;
using SkillTreeMVCHomework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillTreeMVCHomework.Models
{
    public class PaymentService : IPaymentService
    {
        private readonly IRepository<AccountBook> _accountBookRepository;

        public PaymentService(IRepository<AccountBook> accountBookRepository)
        {
            this._accountBookRepository = accountBookRepository;
        }

        public void AddNewPaymentAndSave(Payment newPayment)
        {
            AccountBook accountBook = new AccountBook()
            {
                Amounttt = newPayment.count,
                Remarkkk = newPayment.remark,
                Dateee = newPayment.datetime,
                Categoryyy = ((int)newPayment.moneyType) - 1,
                Id = Guid.NewGuid()
            };
            _accountBookRepository.Add(accountBook);
            _accountBookRepository.Save();
        }

        public List<Payment> GetAllPaymentList()
        {
            List<Payment> paymentList = _accountBookRepository.GetAll()
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