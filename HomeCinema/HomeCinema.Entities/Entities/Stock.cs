using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Entities.Entities
{
   public class Stock:IEntityBase
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public Guid UniqueKey { get; set; }
        public bool IsAvailable { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
