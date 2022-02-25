using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class SPFilemanagement
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int mainid;
        public int Mainid
        {
            get { return mainid; }
            set { mainid = value; }
        }


        private string typename;
        public string Typename
        {
            get { return typename; }
            set { typename = value; }
        }

        private string typedetailname;
        public string Typedetailname
        {
            get { return typedetailname; }
            set { typedetailname = value; }
        }

        private string companyname;
        public string Companyname
        {
            get { return companyname; }
            set { companyname = value; }
        }

        private string fileno;
        public string Fileno
        {
            get { return fileno; }
            set { fileno = value; }
        }

        private string costumername;
        public string Costumername
        {
            get { return costumername; }
            set { costumername = value; }
        }

        private string filename;
        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }
    }
}
