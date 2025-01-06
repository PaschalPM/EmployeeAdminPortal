using EmployeeAdminPortal.Data.Repositories.Interfaces;
using EmployeeAdminPortal.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data.Repositories
{
    public class Repository<T>(ApplicationDbContext context) : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<T> CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var resource = await GetByIdAsync(id);
            if (resource == null) return false;
            _context.Set<T>().Remove(resource);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
