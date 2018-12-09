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
      
using CustomerService.ViewModels;
using Common.ModelToBlClient.Invoice;

namespace CustomerService.Views
{
    /// <summary>
    /// Interaction logic for Receipt.xaml
    /// </summary>
    public partial class Receipt : Page
    {
        public Receipt()
        {
            InitializeComponent();

            ((ReceiptViewModel)DataContext).AcceptCallBack = OnAccept;
        }

        //public List<Common.Model.Receipt> Receipts
        //{
        //    get => ((ReceiptViewModel)DataContext).Receipts;
        //}
        private bool OnAccept(ClientInvoice clientInvoice)
        {
            
            NavigationService.Navigate(new ReceiptResult(clientInvoice));

            return true;
        }
    }

 

}
