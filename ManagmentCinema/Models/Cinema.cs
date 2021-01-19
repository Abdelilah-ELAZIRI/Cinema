using System;
using System.Collections.Generic;

#nullable disable

namespace ManagmentCinema.Models
{
    public partial class Cinema
    {
        public Cinema()
        {
            Salles = new HashSet<Salle>();
        }

        public int IdC { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }

        public virtual ICollection<Salle> Salles { get; set; }
    }
}
