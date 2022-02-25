using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.UIModels
{
    public class DailyAccountingModel
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string satisgorevli;
        public string Satisgorevli
        {
            get { return satisgorevli; }
            set { satisgorevli = value; }
        }

        private string urun;
        public string Urun
        {
            get { return urun; }
            set { urun = value; }
        }

        //private int miktar;
        //public int Miktar
        //{
        //    get { return miktar; }
        //    set { miktar = value; }
        //}

        //private string birim;
        //public string Birim
        //{
        //    get { return birim; }
        //    set { birim = value; }
        //}

        private string randevutarihi;
        public string Randevutarihi
        {
            get { return randevutarihi; }
            set { randevutarihi = value; }
        }

        //private string randevusaati;
        //public string Randevusaati
        //{
        //    get { return randevusaati; }
        //    set { randevusaati = value; }
        //}

        private double fiyat;
        public double Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }

        private string ödemeyöntemi;
        public string Ödemeyöntemi
        {
            get { return ödemeyöntemi; }
            set { ödemeyöntemi = value; }
        }
    }
}
