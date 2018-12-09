using Common.Model;
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
using Customer.ViewModels;
using Common.ModelToBlClient.Invoice;

namespace Customer.Views
{
    /// <summary>
    /// Interaction logic for Receipt.xaml
    /// </summary>
    public partial class Receipt : Page
    {
        public Receipt() : this(null)
        {
        }

        public Receipt(int? clientId)
        {
            InitializeComponent();
            
            var dataContext = ((ReceiptViewModel)DataContext);
            if (dataContext != null)
            {
                dataContext.AcceptCallBack = OnAccept;
                dataContext.ClientId = clientId;
            }
        }

        private bool OnAccept(ClientInvoice clientInvoice)
        {
            
            NavigationService.Navigate(new ReceiptResult(clientInvoice));

            return true;
        }
    }

 

}
