namespace Server.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CartId { get; set; }
        public Cart? Cart { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int Qty { get; set; }
    }
}
