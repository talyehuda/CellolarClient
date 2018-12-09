using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class ClientInvoice
    {
        public string ClientName { get; set; }
        public int ClientId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public double TotalPrice { get; set; }
        public List<LineInvoice> LineInvoices { get; set; }
        //public DateTime DateStart { get; set; }
        //public DateTime DateEnd { get; set; }

    }
}
