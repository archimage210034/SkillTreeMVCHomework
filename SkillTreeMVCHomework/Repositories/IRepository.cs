using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTreeMVCHomework.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAllList();
    }
}
