using StarNote.DataAccess.Repositories.Abstract;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Concrete
{
    public class SPFilemanagementRepository : Repository<SPFilemanagement>, ISPFilemanagementRepository
    {
        public Starnoteapicontext starnoteapicontext { get { return _context as Starnoteapicontext; } }
        public SPFilemanagementRepository(Starnoteapicontext context) : base(context)
        {

        }

        public List<SPFilemanagement> Getidbyfiles(int id)
        {
            return starnoteapicontext.SPFilemanagement.Where(u => u.Id == id).ToList();
        }

    }
}
