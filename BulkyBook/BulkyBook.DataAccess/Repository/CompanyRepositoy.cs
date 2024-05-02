using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public class CompanyRepositoy : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbcontext _db;
        public CompanyRepositoy(ApplicationDbcontext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(Company obj)
        {
            _db.Update(obj);
        }
    }
}
