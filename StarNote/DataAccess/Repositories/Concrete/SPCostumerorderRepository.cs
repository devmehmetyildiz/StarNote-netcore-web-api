using StarNote.DataAccess.Repositories.Abstract;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Concrete
{
    public class SPCostumerorderRepository : Repository<SPCostumerorder>, ISPCostumerorderRepository
    {

        public Starnoteapicontext starnoteapicontext { get { return _context as Starnoteapicontext; } }
        public SPCostumerorderRepository(Starnoteapicontext context) : base(context)
        {

        }

        public string Getmontlygauge(string month, string year, string type)
        {
            return (from c in starnoteapicontext.SPCostumerorder where (c.Salestype == type && c.Deliverydate.Month.ToString() == month && c.Deliverydate.Year.ToString() == year) select c.Price).Sum().ToString();
        }

        public int GetMaxId()
        {
            return starnoteapicontext.SPCostumerorder.Max(u => u.Id);
        }

        public List<SPCostumerorder> GetAllwithRegisterdatefilter(DateTime startdate, DateTime enddate)
        {
            return starnoteapicontext.SPCostumerorder.Where(u => u.Registerdate >= startdate && u.Registerdate <= enddate).ToList();
        }

        public List<SPCostumerorder> GetAllwithDeliverydatefilter(DateTime startdate, DateTime enddate)
        {
            return starnoteapicontext.SPCostumerorder.Where(u => u.Deliverydate >= startdate && u.Deliverydate <= enddate).ToList();
        }
    }
}
