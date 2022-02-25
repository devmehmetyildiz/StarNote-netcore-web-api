using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Abstract
{
    public interface ISPCostumerorderRepository : IRepository<SPCostumerorder>
    {
        int GetMaxId();

        string Getmontlygauge(string month, string year, string type);

        List<SPCostumerorder> GetAllwithRegisterdatefilter(DateTime startdate, DateTime enddate);

        List<SPCostumerorder> GetAllwithDeliverydatefilter(DateTime startdate, DateTime enddate);
    }
}
