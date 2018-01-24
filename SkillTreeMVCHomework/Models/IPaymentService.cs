using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTreeMVCHomework.Models
{
    public interface IPaymentService
    {
        List<Payment> GetAllPaymentList();
    }
}
