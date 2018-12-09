using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ModelToBlClient.OptimalPackage
{
    public class OptimalPackage
    {
        public double ClientValue { get; set; }
        public double TotalMinutes { get; set; }
        public int TotalSMS { get; set; }
        public double TotalMinutesTopNumber { get; set; }
        public double TotalMinutesTop3Number { get; set; }
        public double TotalMinutesFamily { get; set; }
        public double TotalMinutesGeneral { get; set; }
        //public List<Recommendation> ListRecommendation { get; set; }
        public Recommendation Recommendation1 { get; set; }
        public Recommendation Recommendation2 { get; set; }
        public Recommendation Recommendation3 { get; set; }


    }
}
