using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class LineInvoice
    {
        public LineInvoice()
        {
            PackagePrice = 0;
            TotalPrice = 0;
            PackageInfo = null;
            Minutes = 0;
            MinutesLeftInPackage = 0;
            PackagePercentUsage = 0;
            MinutesBeyondPackageLimit = 0;
            MinutePrice = 0;
            TotalMinutesPrice = 0;
            SMS = 0;
            SMSPrice = 0;
            TotalSMSPrice = 0;
            PackagePrice = 0;
            FreindNumbersMinutes = 0;
            FreindNumbersMinutePrice = 0;
            FreindNumbersTotalPrice = 0;
            OutOfPackageTotalPrice = 0;

        }

        public string LineNumber { get; set; }
        public double TotalPrice { get; set; }
        public string PackageInfo { get; set; }
        public double Minutes { get; set; }
        public double MinutesLeftInPackage { get; set; }
        public double PackagePercentUsage { get; set; }
        public double MinutesBeyondPackageLimit { get; set; }
        public double MinutePrice { get; set; }
        public double TotalMinutesPrice { get; set; }
        public int SMS { get; set; }
        public double SMSPrice { get; set; }
        public double TotalSMSPrice { get; set; }
        public double PackagePrice { get; set; }
        public double FreindNumbersMinutes { get; set; }
        public double FreindNumbersMinutePrice { get; set; }
        public double FreindNumbersTotalPrice { get; set; }
        public double OutOfPackageTotalPrice { get; set; }
        public double FamilyNumbersMinutes { get; set; }
        public double MostCalledNumbersMinutes { get; set; }
        //public double PriceFriends { get; set; }
        //public double MinuteFamily { get; set; }
        //public double MinuteFriends { get; set; }
        // public double MinuteMostCalled { get; set; }
        //public string NumberMostCalled { get; set; }
        //public double MinuteAll { get; set; }
        // public ClientType clientType { get; set; }
        //public double PriceSMS { get; set; }
        //public Package Package { get; set; }
    }
}
