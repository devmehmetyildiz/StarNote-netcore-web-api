using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models
{
    public class BaseModel
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string guid;
        public string Guid
        {
            get { return guid; }
            set { guid = value; }
        }

        private string createduser;
        public string Createduser
        {
            get { return createduser; }
            set { createduser = value; }
        }

        private DateTime? deletetime;
        public DateTime? Deletetime
        {
            get { return deletetime; }
            set { deletetime = value; }
        }

        private DateTime? createdtime;
        public DateTime? Createdtime
        {
            get { return createdtime; }
            set { createdtime = value; }
        }

        private DateTime? modifiedtime;
        public DateTime? Modifiedtime
        {
            get { return modifiedtime; }
            set { modifiedtime = value; }
        }

        private bool isactive;
        public bool Isactive
        {
            get { return isactive; }
            set { isactive = value; }
        }


        private string modifieduser;
        public string Modifieduser
        {
            get { return modifieduser; }
            set { modifieduser = value; }
        }

        private int vieworder;
        public int Vieworder
        {
            get { return vieworder; }
            set { vieworder = value; }
        }
    }
}
