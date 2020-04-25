namespace Models
{
    public class Product
    {
        public long id { get; set; }
        public string description { get; set; }
        public bool is_active { get; set; }
        public float price {get; set;}
    }
}