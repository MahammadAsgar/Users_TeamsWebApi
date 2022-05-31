using System.Collections.Generic;

namespace Users_TeamsWebApi.Data.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<User> Users { get; set; }
    }
}
