namespace ProductAPI.Services.Interfaces.BaseService
{
    public interface IBaseService<T>
    {
        public void Add(T entity); 
        public void Delete(T entity); 
        public T GetById(int id); 
        public Task<ICollection<T>> GetAll();
        public T Update(T entity);
    }
}
