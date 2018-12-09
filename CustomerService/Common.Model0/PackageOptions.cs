using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class PackageOptions
    {
        [Key]
        public int Id { get; set; }
        public string PackageName { get; set; }
        public int? MaxMinute { get; set; }
        public double? FixedPrice { get; set; }
        public double? DiscountPercentage { get; set; }
        public bool FavouriteNumbers { get; set; }
        public bool MostCalledNumber { get; set; }
        public bool InsideFamilyCalls { get; set; }

        public Package NewPackage(string packageName, int? maxMinute, double? fixedPrice, double? discountPercentage, int favouriteNumbersId, SelectedNumbers selectedNumbers, bool mostCalledNumber, bool insideFamilyCalls)
        {
            return new Package
            {
                PackageName = packageName,
                MaxMinute = maxMinute,
                FixedPrice = fixedPrice,
                DiscountPercentage = discountPercentage,
                FavouriteNumbers = favouriteNumbersId,
                SelectedNumbers = selectedNumbers,
                MostCalledNumber = mostCalledNumber,
                InsideFamilyCalls = insideFamilyCalls
            };
        }
        public void EditPackage(PackageOptions package)
        {
            PackageName = package.PackageName;
            MaxMinute = package.MaxMinute;
            FixedPrice = package.FixedPrice;
            DiscountPercentage = package.DiscountPercentage;
            FavouriteNumbers = package.FavouriteNumbers;
            MostCalledNumber = package.MostCalledNumber;
            InsideFamilyCalls = package.InsideFamilyCalls;
        }
    }
}
