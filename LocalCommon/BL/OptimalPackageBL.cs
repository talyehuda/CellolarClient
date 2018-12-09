using LocalCommon.BL;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalCommon.DAL;
using Common.ModelToBlClient.OptimalPackage;

namespace LocalCommon.BL
{
    public class OptimalPackageBL: BLBase
    {
        public OptimalPackageBL()
        {
            apiAccess = new WebAPIAccess("optimalpackage");
        }

        public OptimalPackage GetClientOptimalPackage(int clientLineId) {
            return GetAPIData<OptimalPackage>($"getoptimalpackage?lineid={clientLineId}");
        }
    }
}
