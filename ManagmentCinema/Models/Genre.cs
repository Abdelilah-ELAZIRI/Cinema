using System;
using System.Collections.Generic;

#nullable disable

namespace ManagmentCinema.Models
{
    public partial class Genre
    {
        public Genre()
        {
            GenreFilms = new HashSet<GenreFilm>();
        }

        public int IdG { get; set; }
        public string designation { get; set; }

        public virtual ICollection<GenreFilm> GenreFilms { get; set; }
    }
}
