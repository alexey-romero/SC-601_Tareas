using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllObjects();
        Task<T> GetObjectById(int id);
        Task CreateObject(T entity);
        Task UpdateObject(T entity);
        Task DeleteObject(int id);
    }
}
