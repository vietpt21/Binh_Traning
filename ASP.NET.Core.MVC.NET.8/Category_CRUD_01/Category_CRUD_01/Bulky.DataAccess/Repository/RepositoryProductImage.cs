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
    public class RepositoryProductImage : Repository<ProductImage>, IRepositoryProductImage
    {
        private readonly ApplicationDbContext _db;
        public RepositoryProductImage(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}
