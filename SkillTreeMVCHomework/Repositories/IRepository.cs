using System.Linq;

namespace SkillTreeMVCHomework.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        void Add(T item);

        void Save();
    }
}
