using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarNote.Models.DBModels;
namespace StarNote.Models.UIModels
{
    public class OrderModel
    {
        public OrderModel()
        {
            Joborder = new List<SPJoborder>();
        }
        private SPCostumerorder costumerorder;
        public SPCostumerorder Costumerorder
        {
            get { return costumerorder; }
            set { costumerorder = value; }
        }

        private List<SPJoborder> joborder;
        public List<SPJoborder> Joborder
        {
            get { return joborder; }
            set { joborder = value; }
        }
    }
}
