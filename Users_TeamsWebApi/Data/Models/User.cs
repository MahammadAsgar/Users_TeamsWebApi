namespace Users_TeamsWebApi.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public int StatudId { get; set; }
        public Status  Status { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
