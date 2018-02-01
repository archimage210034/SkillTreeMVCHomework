using System.Collections.Generic;

namespace SkillTreeMVCHomework.Models
{
    public interface IPaymentService
    {
        List<Payment> GetAllPaymentList();

        void AddNewPaymentAndSave(Payment newPayment);
    }
}
