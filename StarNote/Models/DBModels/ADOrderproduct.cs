using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class ADOrderproduct : BaseModel
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string groupname;
        public string Groupname
        {
            get { return groupname; }
            set { groupname = value; }
        }

        private string unit;
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        private double baseprice;
        public double Baseprice
        {
            get { return baseprice; }
            set { baseprice = value; }
        }

        private double totalprice;
        public double Totalprice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }
    }
}
