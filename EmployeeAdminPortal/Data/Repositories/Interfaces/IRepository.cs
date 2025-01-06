﻿namespace EmployeeAdminPortal.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid id);

        Task<T?> GetByIdAsync(Guid id);
    }
}
