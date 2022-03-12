namespace AVC_API.Models
{
    public class Product
    {
        public string ID        { get; set; }
        public string Name      { get; set; }
        public string Producer  { get; set; }
        public double Price     { get; set; }
        public int    Stock     { get; set; }
        public bool   Available { get; set; }
    }
}
