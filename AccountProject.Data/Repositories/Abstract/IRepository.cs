using AccountProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AccountProject.API.Repository.Abstract
{
    public interface IRepository<T> 
    {
        void Delete(T entity);
        void Update(T entity);
        void Add(T entity);
        IQueryable<T> GetAll { get; }
        T GetByNumara(string Numara);

        T Get(Expression<Func<T, bool>> filter);
        


    }
}
