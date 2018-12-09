using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ModelToBlClient.Invoice
{
    public class CallDurationPerNumber
    {
        public string Number { get; set; }
        public double SumDuration { get; set; }
        public SendToOptions SendTo { get; set; }
    }
}
