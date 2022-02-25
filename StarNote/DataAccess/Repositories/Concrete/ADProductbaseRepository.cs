using StarNote.DataAccess.Repositories.Abstract;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Concrete
{
    public class ADProductbaseRepository : Repository<ADProductbase>, IADProductbaseRepository
    {
        public ADProductbaseRepository(Starnoteapicontext context) : base(context)
        {

        }
    }
}
