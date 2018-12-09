using Common.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LocalCommon.ViewModels;
using Common.ModelToBlClient.Invoice;

namespace CustomerService.Views
{
    /// <summary>
    /// Interaction logic for ReceiptResult.xaml
    /// </summary>
    public partial class ReceiptResult : Page
    {
        private ClientInvoice _clientInvoice=null;
        public ReceiptResult() : this(null)
        {

        }
        //called by Reciept model with invoice data
        public ReceiptResult(ClientInvoice clientInvoice)
        {
            _clientInvoice = clientInvoice;
            InitializeComponent();
            
            var dataContext = ((ReceiptResultViewModel)DataContext);
            if (dataContext != null)
                //pass invoice data to the view model
                dataContext.ClientInvoice = clientInvoice;
        }
        
    }
}
