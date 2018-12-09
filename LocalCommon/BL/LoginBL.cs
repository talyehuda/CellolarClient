using LocalCommon.BL;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalCommon.DAL;
using Common.ModelToBlClient;

namespace LocalCommon.BL
{
    public class LoginBL:BLBase
    {
        public LoginBL()
        {
            apiAccess = new WebAPIAccess("login");
        }
        public Login LoginAsEmployee(int userId, string contactNumber)
        {
            return GetAPIData<Login>($"loginasemployee?clientidnumber={userId}&contactnumber={contactNumber}");
        }
        public Login LoginAsClient(int userId, string contactNumber)
        {
            return GetAPIData<Login>($"loginasclient?clientidnumber={userId}&contactnumber={contactNumber}");
        }
    }
}
