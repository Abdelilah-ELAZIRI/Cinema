using System;
using System.Collections.Generic;

#nullable disable

namespace ManagmentCinema.Models
{
    public partial class Projection
    {
        public Projection()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int IdP { get; set; }
        public DateTime? DateProjection { get; set; }
        public double? TarifInitial { get; set; }
        public int? IdF { get; set; }
        public int? IdS { get; set; }

        public virtual Film IdFNavigation { get; set; }
        public virtual Salle IdSNavigation { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
