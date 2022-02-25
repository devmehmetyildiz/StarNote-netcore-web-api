using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class SPDefinedcostumer : BaseModel
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string costumerid;
        public string Costumerid
        {
            get { return costumerid; }
            set { costumerid = value; }
        }

        private string phonenumber;
        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string town;
        public string Town
        {
            get { return town; }
            set { town = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
