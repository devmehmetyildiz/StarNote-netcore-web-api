using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class GLCostumertype : BaseModel
    {
        private string parametergroup;
        public string Parametergroup
        {
            get { return parametergroup; }
            set { parametergroup = value; }
        }

        private string parametername;
        public string Parametername
        {
            get { return parametername; }
            set { parametername = value; }
        }
    }
}
