using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
   public class Recommendation
    {
        public Recommendation(string packageName, double packagePrice, double priceForLastMonth)
        {
            this.PackageName = packageName;
            PackagePrice = packagePrice;
            PriceForLastMonth = priceForLastMonth;
        }

        public Recommendation() {

        }

        public int Id { get; set; }
        public string PackageName { get; set; }
        public double PackagePrice { get; set; }
        public double PriceForLastMonth { get; set; }
        
    }
}
