using StarNote.DataAccess.Repositories.Abstract;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Concrete
{
    public class GLNoteRepository : Repository<GLNote>, IGLNoteRepository
    {
        public GLNoteRepository(Starnoteapicontext context) : base(context)
        {

        }
    }
}
