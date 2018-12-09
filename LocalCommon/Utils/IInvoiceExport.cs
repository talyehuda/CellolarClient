using Common.Model;
using Common.ModelToBlClient.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCommon.Utils
{
    public interface IInvoiceExport
    {

        string FilePath { get; set; }
        void Export(ClientInvoice clientInvoice);

    }
}
