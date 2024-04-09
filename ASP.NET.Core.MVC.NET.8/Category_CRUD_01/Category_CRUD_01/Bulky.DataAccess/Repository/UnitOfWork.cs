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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IRepositoryCategory Category { get; private set; }
   
        public IRepositoryProduct Product { get; private set; }
        public IRepositoryCompany Company { get; private set; }
        public IRepositoryApplicationUser ApplicationUser { get; private set; }
        public IRepositoryShoppingCart ShoppingCart { get; private set; }
        public IRepositoryOrderDetail OrderDetail { get; private set; }
        public IRepositoryOrderHeader OrderHeader { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new RepositoryCategory(_db);
            Product = new RepositoryProduct(_db);
            Company = new RepositoryCompany(_db);
            ShoppingCart = new RepositoryShoppingCar(_db);
            ApplicationUser = new RepositoryApplicationUser(_db);
            OrderHeader = new RepositoryOrderHeader(_db);
            OrderDetail = new RepositoryOrderDetail(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
