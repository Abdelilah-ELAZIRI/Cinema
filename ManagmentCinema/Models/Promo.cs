using System;
using System.Collections.Generic;

#nullable disable

namespace ManagmentCinema.Models
{
    public partial class Promo
    {
        public Promo()
        {
            Tickets = new HashSet<Ticket>();
        }

        public string CodeP { get; set; }
        public DateTime? Jour { get; set; }
        public DateTime? DateDebutValidite { get; set; }
        public DateTime? DateFinValidite { get; set; }
        public double? Rabais { get; set; }
        public int? IdF { get; set; }

        public virtual Film IdFNavigation { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
