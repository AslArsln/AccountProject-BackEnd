using AccountProject.API.Repository.Abstract;
using AccountProject.Data;
using AccountProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AccountProject.API.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        SqlDbContext c = new SqlDbContext();
        DbSet<T> _object;

      

         public GenericRepository()
         {
             _object = c.Set<T>();
         }
        
        public void Add(T entity)
        {
            _object.Add(entity);
            c.SaveChanges();
        }

        public T Get(string Numara)
        {
            return _object.Find(Numara);
        }
        public void Update(T entity)
        {
            _object.Update(entity);
            c.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public T GetByNumara(string Numara)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IRepository<T>.GetAll => throw new NotImplementedException();
       
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
    }
