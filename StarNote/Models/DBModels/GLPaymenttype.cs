using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class GLPaymenttype : BaseModel
    {
        private string parametername;
        public string Parametername
        {
            get { return parametername; }
            set { parametername = value; }
        }

        private string parametersmallname;
        public string Parametersmallname
        {
            get { return parametersmallname; }
            set { parametersmallname = value; }
        }

        private double dailygoal;
        public double Dailygoal
        {
            get { return dailygoal; }
            set { dailygoal = value; }
        }
    }
}
