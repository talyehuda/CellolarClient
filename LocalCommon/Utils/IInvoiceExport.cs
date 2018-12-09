using Common.Model;
using Common.ModelToBlClient.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCommon.Utils
{
    /// <summary>
    /// interface for invoice export to file
    /// </summary>
    public interface IInvoiceExport
    {
        string FilePath { get; set; }
        void Export(ClientInvoice clientInvoice);

    }
}
