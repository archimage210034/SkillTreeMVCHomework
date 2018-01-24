using SkillTreeMVCHomework.Enum;
using SkillTreeMVCHomework.Repositories;
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