using StarNote.DataAccess.Repositories.Abstract;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Concrete
{
    public class GLStockRepository : Repository<GLStock>, IGLStockRepository
    {
        public Starnoteapicontext starnoteapicontext { get { return _context as Starnoteapicontext; } }
        public GLStockRepository(Starnoteapicontext context) : base(context)
        {

        }

        public GLStock getstockbyguid(string guid)
        {
            return starnoteapicontext.GLStock.First(u => u.Guid == guid);
        }
    }
}
