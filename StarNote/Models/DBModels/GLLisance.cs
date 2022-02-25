using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.DBModels
{
    public class GLLisance
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string lisansAdı;
        public string LisansAdı
        {
            get { return lisansAdı; }
            set { lisansAdı = value; }
        }

        private string ürünanahtarı;
        public string Ürünanahtarı
        {
            get { return ürünanahtarı; }
            set { ürünanahtarı = value; }
        }

        private string sonaermetarihi;
        public string Sonaermetarihi
        {
            get { return sonaermetarihi; }
            set { sonaermetarihi = value; }
        }

        private string durum;
        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }
    }
}
