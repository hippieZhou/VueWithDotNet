using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VueWithDotNet.Application.Interfaces.Repositories;
using VueWithDotNet.Entities;

namespace VueWithDotNet.Infrastructure.Extensions
{
    public static class UserRepositoryExtension
    {
        public static async Task<User> GetByIdAsync(this IGenericRepository<User> repository, int id)
        {
            return await repository.Queryable.FirstOrDefaultAsync(x => x.Id == id);
        }

        public static async Task<IReadOnlyList<User>> GetAllAsync(this IGenericRepository<User> repository)
        {
            return await repository.Queryable.ToListAsync();
        }
        public static async Task<IReadOnlyList<User>> GetPagedReponseAsync(this IGenericRepository<User> repository, int pageNumber, int pageSize)
        {
            return await repository.Queryable
             .Skip((pageNumber - 1) * pageSize)
             .Take(pageSize)
             .ToListAsync();
        }
        public static async Task<User> AddAsync(this IGenericRepository<User> repository, User entity)
        {
            return await repository.AddAsync(entity);
        }
        public static async Task UpdateAsync(this IGenericRepository<User> repository, User entity)
        {
            await repository.UpdateAsync(entity);
        }
        public static async Task DeleteAsync(this IGenericRepository<User> repository, User entity)
        {
            await repository.DeleteAsync(entity);
        }
    }
}
