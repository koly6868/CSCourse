using System.Collections.Generic;

namespace Domain.Infrastructure
{
    public interface IRepository<T>
    {
        T Get(int ID);
        bool Update(T el);
        bool Add(T el);
        IEnumerable<T> GetAll();
        bool Delete(int ID);
    }
}
