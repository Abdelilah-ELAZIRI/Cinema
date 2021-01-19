using System;
using System.Collections.Generic;

#nullable disable

namespace ManagmentCinema.Models
{
    public partial class GenreFilm
    {
        public int IdF { get; set; }
        public int IdG { get; set; }

        public virtual Film IdFNavigation { get; set; }
        public virtual Genre IdGNavigation { get; set; }
    }
}
