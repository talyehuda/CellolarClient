using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;
using LocalCommon.BL;
using LocalCommon.DAL;

namespace LocalCommon.BL
{
    public class LineInfoBL:BLBase
    {
        
        public LineInfoBL()
        {
            apiAccess = new WebAPIAccess("lineandpackage");
        }

        public List<Line> GetClientLines(int clientId)
        {
            return GetAPIData<List<Line>>($"getlistlinebyclient?clientid={clientId}");
        }

        public List<Package> GetPackages()
        {
            return GetAPIData<List<Package>>($"getlistpackageoptions");
        }

        public Package GetPackageById(int lineId)
        {
            return GetAPIData<Package>($"getpackagebyid?lineid={lineId}");
        }

        public SelectedNumbers GetSelectedNumbersById(int selectedNumbersId)
        {
            return GetAPIData<SelectedNumbers>($"getselectednumbersbyid?id={selectedNumbersId}");
        }

        public double GetPackageTotalFixedPrice(Package package)
        {
            return PostAPIData<double,Package>("gettotalfixedprice",package);
        }

        public int AddPackage(Package package)
        {
            return (int)PostAPIData<int?, Package>("addpackage", package);  
        }
        
        public int AddSelectedNumbers(SelectedNumbers selectedNumbers)
        {
            return (int)PostAPIData<int?, SelectedNumbers>("addselectednumbers", selectedNumbers);
        }

        public int AddLine(Line line,int userId)
        {
            return (int)PostAPIData<int?,Line>($"addline?idemployee={userId}",line);
        }

        public void EditLine(Line line)
        {
            PostAPIData<RequestStatus, Line>("editline", line);
        }

        public void DeleteLine(int lineId)
        {
            GetAPIData<RequestStatus>($"removeline?id={lineId}");
        }
    }
}
