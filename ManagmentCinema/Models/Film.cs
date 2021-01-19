using System;
using System.Collections.Generic;

#nullable disable

namespace ManagmentCinema.Models
{
    public partial class Film
    {
        public Film()
        {
            GenreFilms = new HashSet<GenreFilm>();
            Projections = new HashSet<Projection>();
            Promos = new HashSet<Promo>();
        }

        public int IdF { get; set; }
        public string Titre { get; set; }
        public DateTime? DateSoortie { get; set; }
        public double? Duree { get; set; }
        public string Langue { get; set; }
        public string Realisateur { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<GenreFilm> GenreFilms { get; set; }
        public virtual ICollection<Projection> Projections { get; set; }
        public virtual ICollection<Promo> Promos { get; set; }
    }
}
