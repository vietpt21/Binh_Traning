using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.DataAcess.Data;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class RepositoryCompany : Repository<Company>, IRepositoryCompany
    {
        private readonly ApplicationDbContext _db;
        public RepositoryCompany(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(Company obj)
        {
            _db.companies.Update(obj);
        }
    }
}
