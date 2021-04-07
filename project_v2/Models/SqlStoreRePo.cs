using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace project_v2.Models
{
    public class SqlStoreRePo : IStoreRePo
    {
        private readonly WebContext _context;
        public SqlStoreRePo(WebContext context){
            _context = context;
        }

        public IEnumerable<Store> GetAllStore()
        {
            return _context.Stores.ToList();
        }

        public Store GetStoreByID(int id)
        {
            return _context.Stores.Find(id);
        }
    }
}