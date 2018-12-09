using Common.Model;
using Common.ModelToBlClient;
using LocalCommon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.ViewModels
{
    class MainMenuViewModel:ViewModelBase
    {
        private Login _loginDetails;

        //login details from login dialog in order to be accessed by MainMenu view
        public Login LoginDetails { get => _loginDetails; set => SetProperty(ref _loginDetails, value); }
    }
}
