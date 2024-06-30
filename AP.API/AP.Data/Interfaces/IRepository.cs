using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllObjectsAsync();
        Task<T> GetObjectByIdAsync(int id);
        Task CreateObjectAsync(T entity);
        Task UpdateObjectAsync(T entity);
        Task DeleteObjectAsync(int id);
    }
}