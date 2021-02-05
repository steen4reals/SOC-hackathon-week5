using System.Collections.Generic;
using System.Threading.Tasks;
namespace BackEnd
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        void Delete(long id);
        Task<T> Get(long id);
        Task<T> Update(T t);
        Task<T> Insert(T t);
    }
}