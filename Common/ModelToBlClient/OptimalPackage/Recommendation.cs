using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ModelToBlClient.OptimalPackage
{
   public class Recommendation
    {
        public Recommendation(string namePackage, double pricePackage, double priceForLastMonth)
        {
            PackageName = namePackage;
            PackagePrice = pricePackage;
            PriceForLastMonth = priceForLastMonth;
        }
        public Recommendation()
        {

        }

        public int Id { get; set; }
        public string PackageName { get; set; }
        public double PackagePrice { get; set; }
        public double PriceForLastMonth { get; set; }
        
    }
}
