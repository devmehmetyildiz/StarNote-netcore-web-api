using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class SPDefinedcompany : BaseModel
    {
        private string companyname;
        public string Companyname
        {
            get { return companyname; }
            set { companyname = value; }
        }

        private string companyaddress;
        public string Companyaddress
        {
            get { return companyaddress; }
            set { companyaddress = value; }
        }

        private string taxno;
        public string Taxno
        {
            get { return taxno; }
            set { taxno = value; }
        }

        private string taxname;
        public string Taxname
        {
            get { return taxname; }
            set { taxname = value; }
        }
    }
}
