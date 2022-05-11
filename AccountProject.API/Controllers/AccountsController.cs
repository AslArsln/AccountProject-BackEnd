using AccountProject.Data;
using AccountProject.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
       private readonly SqlDbContext _db; 

        public AccountsController(SqlDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Account> GetAccount()
        {
            var ucretList = _db.Accounts.OrderByDescending(x => x.HesapTarihi).ToList<Account>();
            return ucretList;
        }
      
    }
}
