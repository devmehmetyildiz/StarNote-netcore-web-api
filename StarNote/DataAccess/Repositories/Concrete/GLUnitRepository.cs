using StarNote.DataAccess.Repositories.Abstract;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Concrete
{
    public class GLUnitRepository : Repository<GLUnit>, IGLUnitRepository
    {
        public Starnoteapicontext starnoteapicontext { get { return _context as Starnoteapicontext; } }
        public GLUnitRepository(Starnoteapicontext context) : base(context)
        {

        }
    }
}
