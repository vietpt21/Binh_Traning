using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ApplicatinUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbcontext _db;
        public ApplicatinUserRepository(ApplicationDbcontext db) : base(db)
        {
            _db = db;
        }

        public void Update(ApplicationUser obj)
        {
            _db.Update(obj);
        }
    }
}
