using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ModelToBlClient.Invoice
{
    public class InvoiceCalculationParameters
    {
        public List<Line> Lines { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
