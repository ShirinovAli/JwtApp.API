using System.Linq.Expressions;

namespace JwtApp.API.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task<T?> GetByFilter(Expression<Func<T, bool>> filter);
        Task CreateAsync(T Entity);
        Task UpdateAsync(T Entity);
        Task RemoveAsync(T Entity);
    }
}
