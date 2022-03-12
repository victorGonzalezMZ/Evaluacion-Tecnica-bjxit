namespace AVC_API.Models
{
    public class User
    {
        public string ID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public Profile Profile { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}
