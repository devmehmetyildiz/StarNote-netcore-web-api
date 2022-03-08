using Microsoft.EntityFrameworkCore;
using StarNote.DataAccess.Repositories.Abstract;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Concrete
{
    public class SPJoborderRepository : Repository<SPJoborder>, ISPJoborderRepository
    {
        public Starnoteapicontext starnoteapicontext { get { return _context as Starnoteapicontext; } }
       
        private DbSet<SPJoborder> _dbSet;
        public SPJoborderRepository(Starnoteapicontext context) : base(context)
        {
            _dbSet = starnoteapicontext.Set<SPJoborder>();
        }

        public List<SPJoborder> GetByIDJobOrders(string guid)
        {
            return starnoteapicontext.SPJoborder.Where(u => u.Costumerorder == guid).ToList();
        }

        public List<string> Getusedstocks()
        {
           
            return starnoteapicontext.SPJoborder.Select(u => u.Product).ToList();
        }
    }
}
