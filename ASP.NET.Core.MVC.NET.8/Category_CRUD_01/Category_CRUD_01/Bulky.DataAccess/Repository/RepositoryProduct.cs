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
    public class RepositoryProduct : Repository<Product>, IRepositoryProduct
    {
        private readonly ApplicationDbContext _db;
        public RepositoryProduct(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(Product obj)
        {
            _db.products.Update(obj);
        }
    }
}
