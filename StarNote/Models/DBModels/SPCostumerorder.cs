using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class SPCostumerorder : BaseModel
    {
        private string orderno;
        public string Orderno
        {
            get { return orderno; }
            set { orderno = value; }
        }

        private string costumertype;
        public string Costumertype
        {
            get { return costumertype; }
            set { costumertype = value; }
        }

        private string salestype;
        public string Salestype
        {
            get { return salestype; }
            set { salestype = value; }
        }

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

        private DateTime registerdate;
        public DateTime Registerdate
        {
            get { return registerdate; }
            set { registerdate = value; }
        }

        private DateTime deliverydate;
        public DateTime Deliverydate
        {
            get { return deliverydate; }
            set { deliverydate = value; }
        }

        private string salesman;
        public string Salesman
        {
            get { return salesman; }
            set { salesman = value; }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private double pricewaiting;
        public double Pricewaiting
        {
            get { return pricewaiting; }
            set { pricewaiting = value; }
        }

        private string tax;
        public string Tax
        {
            get { return tax; }
            set { tax = value; }
        }

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

        private string processtype;
        public string Processtype
        {
            get { return processtype; }
            set { processtype = value; }
        }

        private string paymenttype;
        public string Paymenttype
        {
            get { return paymenttype; }
            set { paymenttype = value; }
        }

        private string processcase;
        public string Processcase
        {
            get { return processcase; }
            set { processcase = value; }
        }

        private string info;
        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        private int savetype;
        public int Savetype
        {
            get { return savetype; }
            set { savetype = value; }
        }
    }
}
