namespace GameStoreWeb.Models {
    public class ProductViewModel {
        public Product Product { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();
    }
}
