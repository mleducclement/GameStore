using Microsoft.EntityFrameworkCore;
using System.ComponentModel;


namespace GameStoreWeb.Models {
    public class Product {
        public int Id { get; set; }

        [DisplayName("Title")]
        public required string Title { get; set; }

        [DisplayName("Description")]
        public required string Description { get; set; }

        [DisplayName("Price")]
        [Precision(10, 2)]
        public required decimal Price { get; set; }

        [DisplayName("Genre")]
        // -- Genre.cs --
        public required Genre Genre { get; set; }
    }
}
