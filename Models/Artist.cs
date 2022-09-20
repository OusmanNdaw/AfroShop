using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AfroShop.Models
{
    public class Artist
    {
        public string ArtistId { get; set; }
        public string ArtistFirstName { get; set; }
        public string ArtistLastname { get; set; }
        public string ArtistInfo { get; set; }

        public virtual ICollection<Carving> Carvings { get; set; }
    }
}
