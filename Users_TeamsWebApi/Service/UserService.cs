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
                StatudId = userVM.StatusId
            };

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
    }
}
