using System.Data.Entity;
using System.Linq;

namespace SkillTreeMVCHomework.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbContext DbContext { get; set; }

        private DbSet<T> ObjectSet
        {
            get
            {
                if (_objectset == null)
                {
                    _objectset = this.DbContext.Set<T>();
                }
                return _objectset;
            }
        }
        private DbSet<T> _objectset;

        public Repository(DbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public IQueryable<T> GetAllList()
        {
            return ObjectSet;
        }
    }
}