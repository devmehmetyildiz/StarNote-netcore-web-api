using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class GLStock : BaseModel
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string producttype;
        public string Producttype
        {
            get { return producttype; }
            set { producttype = value; }
        }

        private double amount;
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private string unit;
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        private double incomeprice;
        public double Incomeprice
        {
            get { return incomeprice; }
            set { incomeprice = value; }
        }

        private string outcomeprice;
        public string Outcomeprice
        {
            get { return outcomeprice; }
            set { outcomeprice = value; }
        }

        private string tax;
        public string Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        private double discount;
        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

    }
}
