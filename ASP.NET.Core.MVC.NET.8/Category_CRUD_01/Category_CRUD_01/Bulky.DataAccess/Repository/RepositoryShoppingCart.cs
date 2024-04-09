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
    public class RepositoryShoppingCar : Repository<ShoppingCart>, IRepositoryShoppingCart
    {
        private readonly ApplicationDbContext _db;
        public RepositoryShoppingCar(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
