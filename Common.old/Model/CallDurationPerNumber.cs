using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class CallDurationPerNumber
    {
        public string Number { get; set; }
        public double SumDuration { get; set; }
        public SendToOptions SendTo { get; set; }
    }
}
