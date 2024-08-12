using CarMotorMesh.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CarMotorMesh.Infrastructure.Contacts
{
	public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
	{
		#region Data Fields
		private readonly VehicleContext _dbContext;
		private readonly DbSet<T> _dbSet;
		#endregion

		#region Constructor
		public GenericRepositoryAsync(VehicleContext dbContext)
		{
			_dbContext = dbContext;
			_dbSet = _dbContext.Set<T>();
		}
		#endregion

		public async Task<T> AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
			return entity;
		}

		public async Task AddRangeAsync(ICollection<T> entities)
		{
			await _dbSet.AddRangeAsync(entities);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<IDbContextTransaction> BeginTransactionAsync()
		{
			return await _dbContext.Database.BeginTransactionAsync();
		}

		public async Task DeleteAsync(T entity)
		{
			_dbSet.Remove(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteRangeAsync(ICollection<T> entities)
		{
			foreach (var entity in entities)
			{
				_dbContext.Entry(entity).State = EntityState.Deleted;
			}
			await _dbContext.SaveChangesAsync();
		}

		public async Task<List<T>> GetAll()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public IQueryable<T> GetTableAsTracking()
		{
			return _dbSet.AsTracking();
		}

		public IQueryable<T> GetTableNoTracking()
		{
			return _dbSet.AsNoTracking();
		}

		public async Task UpdateAsync(T entity)
		{
			_dbContext.Entry(entity).State = EntityState.Modified;
			await _dbContext.SaveChangesAsync();
		}

		public async Task UpdateRangeAsync(ICollection<T> entities)
		{
			foreach (var entity in entities)
			{
				_dbContext.Entry(entity).State = EntityState.Modified;
			}
			await _dbContext.SaveChangesAsync();
		}
	}
}
