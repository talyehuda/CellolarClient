using Common.Model;
using LocalCommon.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using LocalCommon.Utils;
using Common.ModelToBlClient.Invoice;

namespace LocalCommon.ViewModels
{
    public class ReceiptResultViewModel:ViewModelBase
    {
     
        private ClientInvoice _clientInvoice;
        
        private DelegateCommand _exportCommand;
        public ICommand ExportCommand { get => _exportCommand; }
        
        private string SuggestFileName(ClientInvoice clientInvoice)
        {
            return  "Invoice_" + clientInvoice.ClientName.Trim().Replace(' ','_') + "_" + clientInvoice.Month + "_" + clientInvoice.Year;
        }

        public ClientInvoice ClientInvoice { get => _clientInvoice; set => SetProperty(ref _clientInvoice, value); }

        public ReceiptResultViewModel()
        {
            _exportCommand = new DelegateCommand(OnExport);
        }

        private void OnExport(object parameter)
        {

            SaveFileDialog x = new SaveFileDialog
            {
                Filter = "PDF|*.pdf|Excel|*.xlsx",
                FileName = SuggestFileName(_clientInvoice),
                AddExtension = true
            };
            ResetMessages();
            if (x.ShowDialog()==true) {
                IInvoiceExport export;
                switch (x.FilterIndex)
                {
                    case 1://PDF


                        ErrorMessage = "Export to PDF is not supported yet";
                        return;
                    default://Excel
                        export = new InvoiceExcportToExcel();
                        break;
                }
                export.FilePath = x.FileName;
                export.Export(_clientInvoice);
                InfoMessage = "Done";
            }
        }

    }
}
