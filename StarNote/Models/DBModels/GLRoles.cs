using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class GLRoles : BaseModel
    {
        private string rolename;
        public string Rolename
        {
            get { return rolename; }
            set { rolename = value; }
        }

        private string rolevalue;
        public string Rolevalue
        {
            get { return rolevalue; }
            set { rolevalue = value; }
        }
    }
}
