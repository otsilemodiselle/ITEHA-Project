using SAOnlineMart.DataAccess.Data;
using SAOnlineMart.DataAccess.Repository.IRepository;
using SAOnlineMart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SAOnlineMart.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
    }
}
