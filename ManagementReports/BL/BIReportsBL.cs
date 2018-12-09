using Common.Model;
using Common.ModelToBlClient;
using LocalCommon.BL;
using LocalCommon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementReports.BL
{
    class BIReportsBL: BLBase
    {
        public BIReportsBL()
        {
            apiAccess = new WebAPIAccess("blreport");
        }

        public BIReport GetBIReport()
        {
            return GetAPIData<BIReport>("getbireport");
        }
    }
}
