using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class ADMenus : BaseModel
    {
        private string parametername;
        public string Parametername
        {
            get { return parametername; }
            set { parametername = value; }
        }
    }
}
