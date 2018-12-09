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

namespace CustomerService.Views
{
    /// <summary>
    /// Interaction logic for LineInformation.xaml
    /// </summary>
    public partial class LineInformation : Page
    {
        public LineInformation() : this(null,null)
        {
        }
        public LineInformation(int? userId, int? clientIdNumber)
        {
            //pass information we got from SelectClient client data to the view model
            InitializeComponent();
            var dataContext = ((LineInformationViewModel)DataContext);
            if (dataContext != null)
            {
                dataContext.UserId = userId;
                dataContext.ClientIdNumber = clientIdNumber;
            }
        }
        
    }
}
