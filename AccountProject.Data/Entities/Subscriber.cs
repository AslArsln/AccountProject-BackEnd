using System;
using System.Collections.Generic;
using System.Text;

namespace AccountProject.Data.Entities
{
    public class Subscriber:BaseEntity
    {
        public string Numara { get; set; }

        public DateTime AcilisTarihi { get; set; }

        public string Adres { get; set; }

        public string AdSoyad { get; set; }
    }
}
