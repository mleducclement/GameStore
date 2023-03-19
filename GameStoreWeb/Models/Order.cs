using System.ComponentModel;

namespace GameStoreWeb.Models
{
    public class Order
    {
        public int Id { get; set; }

        //[DisplayName("Username")]
        public required User User { get; set; }

        [DisplayName("Date Created")]
        public DateTime DateCreated { get; set; }

        //public List<Product> Products { get; set; } = new List<Product>();
    }
}
