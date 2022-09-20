using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfroShop.Models
{
    public class Carving
    {
        public int Id { get; set; }
        public string ArtistId { get; set; }
        public string CarvingName { get; set; }    
        public int CarvingPrice { get; set; }
        public string CarvingDescription { get; set; }

        public string ImageUrl { get; set; }
        public int Quantity { get; set; } 
        public ICollection<Artist> Artists { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
