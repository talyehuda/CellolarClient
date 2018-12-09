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
        public PackageOptions()
        {

        }

        public PackageOptions(int id, string packageName, int? maxMinute, double? fixedPrice, double? discountPercentage, bool favouriteNumbers, bool mostCalledNumber, bool insideFamilyCalls)
        {
            Id = id;
            PackageName = packageName;
            MaxMinute = maxMinute;
            FixedPrice = fixedPrice;
            DiscountPercentage = discountPercentage;
            FavouriteNumbers = favouriteNumbers;
            MostCalledNumber = mostCalledNumber;
            InsideFamilyCalls = insideFamilyCalls;
        }

        [Key]
        public int Id { get; set; }
        public string PackageName { get; set; }
        public int? MaxMinute { get; set; }
        public double? FixedPrice { get; set; }
        public double? DiscountPercentage { get; set; }
        public bool FavouriteNumbers { get; set; }
        public bool MostCalledNumber { get; set; }
        public bool InsideFamilyCalls { get; set; }

        public PackageOptions NewPackage(string packageName, int? maxMinute, double? fixedPrice, double? discountPercentage, bool favouriteNumbersId, bool mostCalledNumber, bool insideFamilyCalls)
        {
            return new PackageOptions
            {
                PackageName = packageName,
                MaxMinute = maxMinute,
                FixedPrice = fixedPrice,
                DiscountPercentage = discountPercentage,
                FavouriteNumbers = favouriteNumbersId,
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
