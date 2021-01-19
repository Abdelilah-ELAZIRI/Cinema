using System;
using System.Collections.Generic;

#nullable disable

namespace ManagmentCinema.Models
{
    public partial class Salle
    {
        public Salle()
        {
            Projections = new HashSet<Projection>();
        }

        public int IdS { get; set; }
        public int? Capacite { get; set; }
        public int? IdC { get; set; }

        public virtual Cinema IdCNavigation { get; set; }
        public virtual ICollection<Projection> Projections { get; set; }
    }
}
