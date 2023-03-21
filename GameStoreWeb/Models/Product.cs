using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameStoreWeb.Models {
    public class Product {
        public int Id { get; set; }

        [Required]
        [DisplayName("Title")]
        public string? Title { get; set; }

        [Required]
        [DisplayName("Description")]
        public string? Description { get; set; }

        [Required]
        [DisplayName("Price")]
        [Precision(10, 2)]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Genre")]
        public Genre Genre { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
