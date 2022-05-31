using System.Collections.Generic;
using System.Linq;
using Users_TeamsWebApi.Data.Models;
using Users_TeamsWebApi.Data.ViewModels;
using Users_TeamsWebApi.Repository;

namespace Users_TeamsWebApi.Service
{
    public class TeamService
    {
        private AppDbContext _context;
        public TeamService(AppDbContext context)
        {
            _context = context;
        }
        public void AddTeam(TeamVM teamVM)
        {
            var users = _context.Users;
            var team = new Team()
            {
                Title = teamVM.TeamTitle,
            };
            foreach (var id in teamVM.UserIds)
            {
                team.Users.Add(users.FirstOrDefault(x => x.Id == id));
            }
            _context.Teams.Add(team);
            _context.SaveChanges();
        }
        public void DeleteTeam(int id)
        {
           _context.Teams.Remove(_context.Teams.FirstOrDefault(x => x.Id == id));
        }
        public Team GetTeam(int id)
        {
            return _context.Teams.FirstOrDefault(x=>x.Id == id);
        }
        public List<Team> GetAllTeams()
        {
            return _context.Teams.ToList();
        }
    }
}

