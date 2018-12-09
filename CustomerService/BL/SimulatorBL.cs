using LocalCommon.BL;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalCommon.DAL;
using Common.ModelToBlClient.Invoice;

namespace CustomerService.BL
{
    class SimulatorBL:BLBase
    {

        public SimulatorBL()
        {
            apiAccess = new WebAPIAccess("simulator");
        }
       
        public void Simulate (SimulationParameters simulationParameters)
        {
            PostAPIData("addsimulationparameters", simulationParameters);
        }
        

    }
}
