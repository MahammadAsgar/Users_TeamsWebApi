using System.Collections.Generic;

namespace Users_TeamsWebApi.Data.ViewModels
{
    public class TeamVM
    {
        public string TeamTitle { get; set; }
        public List<int> UserIds { get; set; }
    }
}
