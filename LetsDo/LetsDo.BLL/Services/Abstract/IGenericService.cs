
using System.Linq.Expressions;
namespace LetsDo.BLL.Services.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(string? includeProporties = null);
        Task<T> GetByIdAsync(int id, string? includeProperties = null);
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
    }
}
