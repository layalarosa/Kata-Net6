using Kata_Net6.Core.IRepositories;


namespace Kata_Net6.Core.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        //protected DbSet<T> dbSet;
        protected readonly ILogger _logger;

        public GenericRepository(

            ILogger logger
        )
        {

            _logger = logger;

        }

        public virtual async Task<IEnumerable<T>> All()
        {
            //return await dbSet.ToListAsync();
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetById(int id)
        {
            //return await dbSet.FindAsync(id);
            throw new NotImplementedException();
        }

        public virtual async Task<bool> Add(T entity)
        {
            //await dbSet.AddAsync(entity);
            //return true;
            throw new NotImplementedException();
        }

        public virtual Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
