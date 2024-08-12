using Microsoft.EntityFrameworkCore.Storage;

namespace CarMotorMesh.Infrastructure.Contacts
{
	public interface IGenericRepositoryAsync<T> where T : class
	{
		Task<List<T>> GetAll();
		Task<T> GetByIdAsync(int id);
		Task DeleteRangeAsync(ICollection<T> entities);
		Task<IDbContextTransaction> BeginTransactionAsync();
		IQueryable<T> GetTableNoTracking();
		IQueryable<T> GetTableAsTracking();
		Task<T> AddAsync(T entity);
		Task AddRangeAsync(ICollection<T> entities);
		Task UpdateAsync(T entity);
		Task UpdateRangeAsync(ICollection<T> entities);
		Task DeleteAsync(T entity);
	}
}
