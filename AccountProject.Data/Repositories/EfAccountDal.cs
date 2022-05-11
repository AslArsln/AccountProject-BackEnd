using AccountProject.API.Repository;
using AccountProject.API.Repository.Abstract;
using AccountProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountProject.Data.Repositories
{
    public class EfAccountDal:GenericRepository<Account>,IAccountDal
    {

    }
}
