using System;
using System.Collections.Generic;

#nullable disable

namespace ManagmentCinema.Models
{
    public partial class Ticket
    {
        public int IdT { get; set; }
        public DateTime? DateVente { get; set; }
        public string CodePromo { get; set; }
        public int? IdP { get; set; }

        public virtual Promo CodePromoNavigation { get; set; }
        public virtual Projection IdPNavigation { get; set; }
    }
}
