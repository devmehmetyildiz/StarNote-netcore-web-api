using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class ADProductbase
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

        private string stockguid;
        public string Stockguid
        {
            get { return stockguid; }
            set { stockguid = value; }
        }

        private double amount;
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }
}
