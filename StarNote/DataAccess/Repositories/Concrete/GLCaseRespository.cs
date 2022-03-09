using Microsoft.EntityFrameworkCore;
using StarNote.DataAccess.Repositories.Abstract;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Concrete
{
    public class GLCaseRespository : Repository<GLCase>, IGLCaseRespository
    {
        public Starnoteapicontext starnoteapicontext { get { return _context as Starnoteapicontext; } }

        private DbSet<GLCase> _dbSet;
        public GLCaseRespository(Starnoteapicontext context) : base(context)
        {
            _dbSet = starnoteapicontext.Set<GLCase>();
        }

        public List<GLCase> filteredcases()
        {            
            return _dbSet.FromSqlRaw<GLCase>("select * from GLCase where Parametername = 'TAMAMLANDI'").ToList();
        }
    }
}
