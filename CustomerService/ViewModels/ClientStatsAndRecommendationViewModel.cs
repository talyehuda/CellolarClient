using Common.Model;
using LocalCommon.BL;
using LocalCommon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.ViewModels
{
    /// <summary>
    /// //extension for StatsAndRecommendationViewModel with the ability to select client
    /// </summary>

    class ClientStatsAndRecommendationViewModel : StatsAndRecommendationViewModel
    {
        private ClientInfoBL clientInfoBL;
        private List<int> _clientIdNumbers;
        private int? _selectedClientIdNumber;

        public ClientStatsAndRecommendationViewModel():base()
        {
            clientInfoBL = new ClientInfoBL();
            ResetMessages();
            try {
                ClientIdNumbers = clientInfoBL.GetClientIdNumbers();
            }
            catch(Exception ex)
            {
                SetErrorMessage(ex, "loading data");
            }
        }

        public List<int> ClientIdNumbers
        {
            get => _clientIdNumbers; set
            {
                SetProperty(ref _clientIdNumbers, value);
                SelectedClientIdNumber = null;
            }
        }
        public int? SelectedClientIdNumber
        {
            get => _selectedClientIdNumber; set
            {
                SetProperty(ref _selectedClientIdNumber, value);
                ResetMessages();
                if (_selectedClientIdNumber != null)
                {
                    try
                    {
                        Client client = clientInfoBL.GetClientByIdNumber((int)_selectedClientIdNumber);
                        ClientId = client.Id;
                    }
                    catch(Exception ex)
                    {
                        SetErrorMessage(ex,"loading client data");
                    }
                }
            }
        }
    }
}
