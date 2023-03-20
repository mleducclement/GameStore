namespace GameStoreWeb.Models {
    public class OrderProduct {
        public int Id { get; set; }
        public required Product Product { get; set; }
        public required Order Order { get; set; }
        public int Quantity { get; set; }
    }
}
