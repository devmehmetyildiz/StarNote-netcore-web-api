using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.UIModels
{
    public class SalesmanAnalysisModel
    {
        private int ıd;
        public int Id
        {
            get { return ıd; }
            set { ıd = value; }
        }

        private string görevli;
        public string Görevli
        {
            get { return görevli; }
            set { görevli = value; }
        }

        private string ürün;
        public string Ürün
        {
            get { return ürün; }
            set { ürün = value; }
        }

        private string birim;
        public string Birim
        {
            get { return birim; }
            set { birim = value; }
        }

        private int adet;
        public int Adet
        {
            get { return adet; }
            set { adet = value; }
        }

        private double ücret;
        public double Ücret
        {
            get { return ücret; }
            set { ücret = value; }
        }
    }
}
