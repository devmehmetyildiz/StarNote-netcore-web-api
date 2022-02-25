using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Abstract
{
    public interface ISPJoborderRepository : IRepository<SPJoborder>
    {
        List<SPJoborder> GetByIDJobOrders(string guid);

        List<string> Getusedstocks();
    }
}
