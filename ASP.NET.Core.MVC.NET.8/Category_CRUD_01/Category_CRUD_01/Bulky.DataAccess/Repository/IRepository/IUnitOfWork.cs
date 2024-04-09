using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IRepositoryCategory Category { get; }
        IRepositoryProduct Product { get; }
        IRepositoryCompany Company { get; }
        IRepositoryShoppingCart ShoppingCart { get; }
        IRepositoryOrderDetail OrderDetail { get; }
        IRepositoryOrderHeader OrderHeader { get; }
        IRepositoryApplicationUser ApplicationUser { get; }
        void Save();
    }
}
