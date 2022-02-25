using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.UIModels
{
    public class AdisyonorderModel
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string salestypeid;
        public string Salestypeid
        {
            get { return salestypeid; }
            set { salestypeid = value; }
        }


        private string costumerid;
        public string Costumerid
        {
            get { return costumerid; }
            set { costumerid = value; }
        }


        private List<ADOrderproduct> productlist;
        public List<ADOrderproduct> Productlist
        {
            get { return productlist; }
            set { productlist = value; }
        }

        private double ordertotalprice;
        public double Ordertotalprice
        {
            get { return ordertotalprice; }
            set { ordertotalprice = value; }
        }

        private int paymentid;
        public int Paymentid
        {
            get { return paymentid; }
            set { paymentid = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string user;
        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private DateTime orderstarttime;
        public DateTime Orderstarttime
        {
            get { return orderstarttime; }
            set { orderstarttime = value; }
        }

        private DateTime orderfinishtime;
        public DateTime Orderfinishtime
        {
            get { return orderfinishtime; }
            set { orderfinishtime = value; }
        }
    }
}
