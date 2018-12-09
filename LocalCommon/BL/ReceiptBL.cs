using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;
using LocalCommon.BL;
using LocalCommon.DAL;
using Common.ModelToBlClient.Invoice;

namespace LocalCommon.BL
{
    public class ReceiptBL:BLBase
    {
        public ReceiptBL()
        {
            apiAccess = new WebAPIAccess("invoice");
        }

        public ClientInvoice GetClientInvoice(List<Line> selectedLines,int month, int year)
        {

            return PostAPIData <ClientInvoice, List<Line>>($"calculateinvoice?month={month}&year={year}",selectedLines);
        }
    }
}
