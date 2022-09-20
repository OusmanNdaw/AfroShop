namespace AfroShop.Models
{
    public class Order
    {
        public int CreateDate { get; set; }
        public int RequestDate { get; set; } 
        public int Shipment { set; get; }
        public int Comment { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Carving> Carvings { get; set; }

    }
}



// PlacedDate and Fullfilled Date