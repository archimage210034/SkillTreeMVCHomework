using SkillTreeMVCHomework.Enum;
using System.Collections.Generic;
using System.Linq;

namespace SkillTreeMVCHomework.Models
{
    public class PaymentService
    {
        private SkillTreeHomeworkContent skillTreeHomeworkContent;

        public PaymentService()
        {
            skillTreeHomeworkContent = new SkillTreeHomeworkContent();
        }

        public List<Payment> GetAllPaymentList()
        {
            List<Payment> paymentList = skillTreeHomeworkContent.AccountBook
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