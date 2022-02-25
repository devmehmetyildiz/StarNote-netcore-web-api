using StarNote.DataAccess.Repositories.Abstract;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Concrete
{
    public class ADMenusRepository : Repository<ADMenus>, IADMenusRepository
    {
        public Starnoteapicontext starnoteapicontext { get { return _context as Starnoteapicontext; } }

        public ADMenusRepository(Starnoteapicontext context) : base(context)
        {

        }
    }
}
