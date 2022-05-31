using System.Collections.Generic;
using System.Linq;
using Users_TeamsWebApi.Data.Models;
using Users_TeamsWebApi.Data.ViewModels;
using Users_TeamsWebApi.Repository;

namespace Users_TeamsWebApi.Service
{
    public class StatusService
    {
        private AppDbContext _context;
        public StatusService(AppDbContext context)
        {
            _context = context;
        }
        public void AddStatus(StatusVM statusVM)
        {
            var status = new Status()
            {
                Title = statusVM.Title
            };
            _context.Add(status);
            _context.SaveChanges();
        }
        public Status GetStatus(int id)
        {
            return _context.Statuses.FirstOrDefault(x => x.Id == id);
        }
        public List<Status> GetAllStatuses()
        {
            return _context.Statuses.ToList();
        }
    }
}
