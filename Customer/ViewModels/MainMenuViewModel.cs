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

        public Login LoginDetails { get => _loginDetails; set => SetProperty(ref _loginDetails, value); }
    }
}
