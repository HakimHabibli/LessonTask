using Microsoft.EntityFrameworkCore;
using ProductAPI.DAL;
using ProductAPI.Models.Common;
using ProductAPI.Services.Interfaces.BaseService;
using ProductAPI.Utilities.Exceptions;
using ProductAPI.Utilities.ResponseMessages;
using System.Net;

namespace ProductAPI.Services.Implementations.Base
{
    public class BaseService<T> : IBaseService<T> where T : class
    {

        private readonly AppDbContext _context;
        private DbSet<T> _dbSet;
        public BaseService(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
           _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<ICollection<T>> GetAll()
        {
           return await _dbSet.ToListAsync();
        }

        public ResponseMessage GetById(int id)
        {
            T entity = _dbSet.Find(id);
            if (entity== null)
            {
                throw new NotFoundException("Not Found");
            }
            return new ResponseMessage() { 
            Data = entity,
            Message = "ENTITIY FOUND",
            StatusCode = HttpStatusCode.OK,
            };
        }

        public T Update(T entity)
        {
           _dbSet.Update(entity);
            return entity;
        }
    }
}
