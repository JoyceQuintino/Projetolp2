using System;
using System.Collections.Generic;
using System.Text;
using laiscegonha.Models;

namespace laiscegonha.Repositories
{
    public interface IRepositoryBase<T> where T : class, IEntidade
    {
        T CreateT(T entidade);
        IEnumerable<T> GetAll();
        T Find(int id);
        void Remove(int id);
        void Update(T entidade);
    }
}
