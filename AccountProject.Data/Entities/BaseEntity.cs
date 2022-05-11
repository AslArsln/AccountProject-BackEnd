using System;
using System.Collections.Generic;
using System.Text;

namespace AccountProject.Data.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int TarifeBirimId { get; set; }

        public int KdvOranId { get; set; }
    }
}
