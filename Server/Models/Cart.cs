namespace Server.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public DateTime CartDate { get; set; } = DateTime.Now;
    }
}
