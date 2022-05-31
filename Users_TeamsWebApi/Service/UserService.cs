using System.Collections.Generic;
using System.Linq;
using Users_TeamsWebApi.Data.Models;
using Users_TeamsWebApi.Data.ViewModels;
using Users_TeamsWebApi.Repository;

namespace Users_TeamsWebApi.Service
{
    public class UserService
    {
        private AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }
        public void AddUser(UserVM userVM)
        {
           
            var user = new User()
            {
                UserName = userVM.UserName,
                Password = System.Text.Encoding.UTF8.GetBytes(userVM.Password).ToString(),
            };
            foreach (var item in _context.Statuses)
            {
              if(item.Id==userVM.StatusId)
                {
                    user.Status = item;
                    break;
                }
            }
            foreach (var item in _context.Teams)
            {
                if (item.Id==userVM.TeamId)
                {
                    user.Team = item;
                    break;
                }
            }
  
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public void DeleteUser(int id)
        {
            _context.Users.Remove(_context.Users.FirstOrDefault(x => x.Id == id));
        }
        public User GetUser(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        public List<User> GetUserByStatusId(int statusId)
        {
            List<User> users = new List<User>();
            foreach (var item in _context.Users)
            {
                if (item.Status.Id == statusId)
                {
                    users.Add(item);
                }
            }
            return users;
        }
        public List<User> GetUserByTeamId(int teamId)
        {
            List<User> users = new List<User>();
            foreach (var item in _context.Users)
            {
                if (item.Team.Id== teamId)
                {
                    users.Add(item);
                }
            }
            return users;
        }
    }
}
