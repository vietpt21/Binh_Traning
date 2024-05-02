using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbcontext _db;
        public CoverTypeRepository(ApplicationDbcontext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(CoverType obj)
        {
            _db.Update(obj);
        }
    }
}
