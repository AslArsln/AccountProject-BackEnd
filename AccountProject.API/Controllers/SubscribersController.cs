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
    public class SubscribersController : ControllerBase
    {
        private readonly SqlDbContext _db; 

        public SubscribersController(SqlDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public List<Subscriber> GetSubscriber()
        {
            var subscriberList = _db.Subscribers.OrderBy(x => x.Numara).ToList<Subscriber>();
            return subscriberList;
        }

        [HttpGet("numara}")]
        public Subscriber GetByNumara(String numara)
        {
            var subscriber = _db.Subscribers.Where(subscriber => subscriber.Numara == numara).SingleOrDefault();
            return subscriber;
        }

        [HttpPut("{Id}")]
        public IActionResult Update(int Id,[FromBody] Subscriber update)
        {
            var subscriber = _db.Subscribers.SingleOrDefault(X => X.Id == Id);
            if (subscriber is null)
                return BadRequest();

            subscriber.AcilisTarihi = update.AcilisTarihi != default ? update.AcilisTarihi : subscriber.AcilisTarihi;
            subscriber.Adres = update.Adres = default ? update.Adres : subscriber.Adres;
            subscriber.AdSoyad = update.AdSoyad != default ? update.AdSoyad : subscriber.AdSoyad;
            subscriber.Numara = update.Numara != default ? update.Numara:subscriber.Numara;
            subscriber.TarifeBirimId = update.TarifeBirimId != default ? update.TarifeBirimId : subscriber.TarifeBirimId;
            subscriber.KdvOranId = update.KdvOranId != default ? update.KdvOranId : subscriber.KdvOranId;

            _db.SaveChanges();
            return Ok();
        }


        [HttpDelete("{Id} ")]
        public IActionResult DeleteSubscriber(int id)
        {
            var subscriber = _db.Subscribers.SingleOrDefault(X => X.Id ==id);
            if (subscriber is null)
                return BadRequest();

            _db.Subscribers.Remove(subscriber);
            _db.SaveChanges();
            return Ok();
        }

    }
}
