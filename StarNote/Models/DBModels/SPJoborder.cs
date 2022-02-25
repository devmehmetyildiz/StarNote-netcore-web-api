using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class SPJoborder : BaseModel
    {
        private string costumerorder;
        public string Costumerorder
        {
            get { return costumerorder; }
            set { costumerorder = value; }

        }

        private string joborderno;
        public string Joborderno
        {
            get { return joborderno; }
            set { joborderno = value; }
        }

        private string product;
        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        private string propducttype;
        public string Propducttype
        {
            get { return propducttype; }
            set { propducttype = value; }
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

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
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
    }
}
