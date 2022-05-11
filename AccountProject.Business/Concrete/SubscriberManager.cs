using AccountProject.API.Repository.Abstract;
using AccountProject.Business.Abstract;
using AccountProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace AccountProject.Business.Concrete
{
    public class SubscriberManager:ISubscriberService<Subscriber>
    {
        private readonly ISubscriberDal _subscriber;


         public SubscriberManager(ISubscriberDal subscriber)
         {
             _subscriber = subscriber;

         }
         public void Add(Subscriber subscriber)
         {
             _subscriber.Add(subscriber);
         }


         public void Delete(Subscriber subscriber)
         {
             _subscriber.Delete(subscriber);


         }
        public void Update(Subscriber subscriber)
        {

            _subscriber.Update(subscriber);


        }
        public Subscriber GetByNumara(string Numara)
         {
             throw new NotImplementedException();
         }

        

         void ISubscriberService<Subscriber>.Delete(Subscriber subscriber)
         {
             throw new NotImplementedException();
         }
    }
}
