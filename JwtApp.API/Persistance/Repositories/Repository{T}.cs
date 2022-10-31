using JwtApp.API.Core.Application.Interfaces;
using JwtApp.API.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JwtApp.API.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly JwtAppContext _context;

        public Repository(JwtAppContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T Entity)
        {
            await _context.Set<T>().AddAsync(Entity);
            _context.SaveChanges();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T Entity)
        {
            _context.Set<T>().Remove(Entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T Entity)
        {
            _context.Set<T>().Update(Entity);
            await _context.SaveChangesAsync();
        }
    }
}
