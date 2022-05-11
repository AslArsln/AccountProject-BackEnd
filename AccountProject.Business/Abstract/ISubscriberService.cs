using AccountProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountProject.Business.Abstract
{
    public interface ISubscriberService<T>
    {
        void Delete(T subscriber);
        void Update(T subscriber);
        void Add(T subscriber);
        T GetByNumara(string Numara);
    }
}
