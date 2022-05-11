using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccountProject.Data.Entities
{
    public class Account:BaseEntity
    {
        
        public decimal TarifeBirimFiyat { get; set; }
   
        public decimal İlkEndeks { get; set; }
     
        public decimal SonEndeks { get; set; }
        public DateTime HesapTarihi { get; set; }
       
        public decimal TarifeKdvFiyat { get; set; }
        
        public decimal TarifeToplamFiyat { get; set; }
        public AccountType HesaplamaTürü { get; set; }

        
    }
}
