using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.UIModels
{
    public class SalestypeModel
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string productguid;
        public string Productguid
        {
            get { return productguid; }
            set { productguid = value; }
        }

        private string optionproductguid;
        public string Optionproductguid
        {
            get { return optionproductguid; }
            set { optionproductguid = value; }
        }

        private double totalprice;
        public double Totalprice
        {
            get { return totalprice; }
            set { totalprice = value; }
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

        private double baseprice;
        public double Baseprice
        {
            get { return baseprice; }
            set { baseprice = value; }
        }
    }
}
