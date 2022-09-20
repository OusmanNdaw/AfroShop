namespace AfroShop.Models
{
    public class Payment
    {
        private ICollection<Carving> carvings;

            public int CreateDate { get; set; }
            public int AmountToBePaid { get; set; }
            public int PaymentDone { get; set; }

           // public ICollection<Order> Orders { get; set; }
            // public ICollection<Carving> Carvings { get => carvings; set => carvings = value; }

        }
    }



