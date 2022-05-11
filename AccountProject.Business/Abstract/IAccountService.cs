using AccountProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AccountProject.Business.Abstract
{
    public interface IAccountService<TElement>
    {
        IOrderedEnumerable<TElement> GetElements(Expression<Func<TElement, bool>> filter);
        TElement Get(Expression<Func<TElement, bool>> filter);

    }
}
