using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.UIModels
{
    public class GaugeModel
    {
        private string gaugename;
        public string Gaugename
        {
            get { return gaugename; }
            set { gaugename = value; }
        }

        private string gaugevalue;
        public string Gaugevalue
        {
            get { return gaugevalue; }
            set { gaugevalue = value; }
        }
    }
}
