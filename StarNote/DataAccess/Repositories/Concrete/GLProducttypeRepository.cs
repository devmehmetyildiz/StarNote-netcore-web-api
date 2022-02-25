using StarNote.DataAccess.Repositories.Abstract;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Concrete
{
    public class GLProducttypeRepository : Repository<GLProducttype>, IGLProducttypeRepository
    {
        public GLProducttypeRepository(Starnoteapicontext context) : base(context)
        {

        }
    }
}
