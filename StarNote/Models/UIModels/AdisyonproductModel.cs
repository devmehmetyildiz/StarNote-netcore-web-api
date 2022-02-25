using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarNote.Models.DBModels;

namespace StarNote.Models.UIModels
{
    public class AdisyonproductModel
    {
        private ADOrderproduct product;
        public ADOrderproduct Product
        {
            get { return product; }
            set { product = value; }
        }

        private List<ADProductbase> productbase;
        public List<ADProductbase> Productbase
        {
            get { return productbase; }
            set { productbase = value; }
        }

        private List<ADProductoption> propductoption;
        public List<ADProductoption> Productoption
        {
            get { return propductoption; }
            set { propductoption = value; }
        }
    }
}
