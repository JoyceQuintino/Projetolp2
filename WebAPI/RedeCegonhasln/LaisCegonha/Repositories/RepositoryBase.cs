using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using laiscegonha.Context;
using laiscegonha.Models;

namespace laiscegonha.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntidade
    {
        private readonly LaisContext _context;

        public RepositoryBase(LaisContext context)
        {
            this._context = context;
        }
        public virtual T CreateT(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual T Find(int id)
        {
            return _context.Set<T>().FirstOrDefault(c => c.Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual void Remove(int id)
        {
            var exist = _context.Set<T>().First(c => c.Id == id);
            _context.Set<T>().Remove(exist);
            _context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
