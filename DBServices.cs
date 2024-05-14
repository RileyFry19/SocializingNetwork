using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheSocializingNetwork.Models;

namespace TheSocializingNetwork.Data
{
    public class DBServices
    {
        private DataContext _context;

        public DBServices(DataContext context)
        {
            _context = context;
        }

        public void CreateAccount(User user, Profile profile)
        {
            user.UserId = Guid.NewGuid();
            _context.Users.Add(user);
            profile.ProfileId = Guid.NewGuid();
            profile.UserId = user.UserId;
            _context.Profiles.Add(profile);
            _context.SaveChanges();
        }
    }
}
