using Microsoft.EntityFrameworkCore.Query;

namespace TaskEvaluation.Core.Interfaces.IRepositories
{
	public interface IBaseRepository<T> where T : class
    {
		Task<IEnumerable<T>> GetAll();
		Task<T> GetById<IdType>(IdType id);
		Task<T> Create(T model);
		Task Update(T model);
		Task Delete(T model);
		Task SaveChangesAsync();
	}
}
