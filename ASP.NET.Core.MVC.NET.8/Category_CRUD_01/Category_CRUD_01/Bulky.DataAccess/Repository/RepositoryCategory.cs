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
    public class RepositoryCategory : Repository<Category>, IRepositoryCategory
    {
        private readonly ApplicationDbContext _db;
        public RepositoryCategory(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
