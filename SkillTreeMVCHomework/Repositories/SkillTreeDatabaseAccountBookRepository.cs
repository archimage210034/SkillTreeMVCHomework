using System.Data.Entity;
using System.Linq;

namespace SkillTreeMVCHomework.Repositories
{
    public class SkillTreeDatabaseAccountBookRepository<T> : IRepository<T> where T : class
    {
        public IMyUnitOfWork UnitOfWork { get; set; }

        private DbSet<T> ObjectSet
        {
            get
            {
                if (_objectset == null)
                {
                    _objectset = this.UnitOfWork.Context.Set<T>();
                }
                return _objectset;
            }
        }
        private DbSet<T> _objectset;

        public SkillTreeDatabaseAccountBookRepository(IMyUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public IQueryable<T> GetAll()
        {
            return ObjectSet;
        }
    }
}