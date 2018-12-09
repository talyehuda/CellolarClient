using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class SimulationParameters
    {
        public SimulationParameters(int lineId, double minDuration, double maxDuration, int numberOfCallsOrSMS, bool sMS, SendToOptions sendToOptions)
        {
            LineId = lineId;
            MinDuration = minDuration;
            MaxDuration = maxDuration;
            NumberOfCallsOrSMS = numberOfCallsOrSMS;
            SMS = sMS;
            SendToOptions = sendToOptions;
        }
        public SimulationParameters()
        {

        }

        public int LineId { get; set; }
        public double MinDuration { get; set; }
        public double MaxDuration { get; set; }
        public int NumberOfCallsOrSMS { get; set; }
        public bool SMS { get; set; }
        public SendToOptions SendToOptions { get; set; }
        
    }
}
