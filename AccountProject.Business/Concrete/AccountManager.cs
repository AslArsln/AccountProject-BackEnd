using AccountProject.API.Repository.Abstract;
using AccountProject.Business.Abstract;
using AccountProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AccountProject.Data.Entities;

namespace AccountProject.Business.Concrete
{
   public class AccountManager:IAccountService<Account>
    {
        private readonly IAccountDal _accountDal;

        
        public AccountManager(IAccountDal account)
        {

            _accountDal=account;
        }

        public Account Get(Expression<Func<Account, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IOrderedEnumerable<Account> GetElements(Expression<Func<Account, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
