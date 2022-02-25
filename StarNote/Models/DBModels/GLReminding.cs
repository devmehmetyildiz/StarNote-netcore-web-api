using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class GLReminding : BaseModel
    {
        private string remindingtype;
        public string Remindingtype
        {
            get { return remindingtype; }
            set { remindingtype = value; }
        }

        private string cycletype;
        public string Cycletype
        {
            get { return cycletype; }
            set { cycletype = value; }
        }

        private string cycleper;
        public string Cycleper
        {
            get { return cycleper; }
            set { cycleper = value; }
        }

        private string reporttype;
        public string Reporttype
        {
            get { return reporttype; }
            set { reporttype = value; }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        private string users;
        public string Users
        {
            get { return users; }
            set { users = value; }
        }

    }
}
