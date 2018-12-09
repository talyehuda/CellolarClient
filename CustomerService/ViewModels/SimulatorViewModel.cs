using Common.Model;
using LocalCommon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CustomerService.BL;
using LocalCommon.BL;
using Common.ModelToBlClient.Invoice;

namespace CustomerService.ViewModels
{
    public class SimulatorViewModel : ViewModelBase
    {
        private ClientInfoBL clientInfoBL;
        private LineInfoBL lineInfoBL;
        private SimulatorBL simulatorBL;

        private DelegateCommand _simulateCommand=null;
        public ICommand SimulateCommand { get => _simulateCommand; }

        private IList<int> _clientIdNumbers;
        private int? _selectedClientIdNumber;
        private IList<Line> _lines;
        private Line _selectedLine;
        private SimulationParameters _simulationParameters;

        
        public IList<int> ClientIdNumbers { get => _clientIdNumbers; set => SetProperty(ref _clientIdNumbers, value); }
        public int? SelectedClientIdNumber
        {
            get => _selectedClientIdNumber;
            set {
                SetProperty(ref _selectedClientIdNumber, value);

                ResetMessages();
                if (SelectedClientIdNumber != null)
                {
                    try
                    {
                        Client client = clientInfoBL.GetClientByIdNumber((int)SelectedClientIdNumber);
                        Lines = lineInfoBL.GetClientLines(client.Id);
                    }
                    catch (Exception ex)
                    {
                        SetErrorMessage(ex, "loading client lines");
                        return;
                    }
                }

                _simulateCommand.InvokeCanExecuteChanged();
            }
        }
        public IList<Line> Lines { get => _lines; set => SetProperty(ref _lines, value); }
        public Line SelectedLine
        {
            get => _selectedLine;
            set
            {
                SetProperty(ref _selectedLine, value);
                if (SelectedLine != null)
                {
                    SimulationParameters.LineId = SelectedLine.Id;
                }
                _simulateCommand.InvokeCanExecuteChanged();
            }
        }
        public SimulationParameters SimulationParameters { get => _simulationParameters; set => SetProperty(ref _simulationParameters, value); }
        
        public SimulatorViewModel()
        {
            clientInfoBL = new ClientInfoBL();
            lineInfoBL = new LineInfoBL();
            simulatorBL = new SimulatorBL();

            _simulateCommand = new DelegateCommand(OnSimulate, CanSave);

            _simulationParameters = new SimulationParameters();

            ResetMessages();
            try
            {
                ClientIdNumbers = clientInfoBL.GetClientIdNumbers();
            }
            catch (Exception ex)
            {
                SetErrorMessage(ex, "loading data");
                return;
            }
        }

        private void OnSimulate(object obj)
        {
            
            if (CheckFields()) {

                ResetMessages();
                try
                {
                    simulatorBL.Simulate(SimulationParameters);
                    InfoMessage = "Done";
                }
                catch (Exception ex)
                {
                    SetErrorMessage (ex,"simulating");
                }
            }
        }

        private bool CheckFields()
        {
            bool ret = false;
            ResetMessages();

            if (_simulationParameters.MinDuration < 0)
                ErrorMessage = "Min Duration must be non-negative";
            else if (_simulationParameters.MaxDuration < 0)
                ErrorMessage = "Max Duration must be non-negative";
            else if (_simulationParameters.MinDuration >= _simulationParameters.MaxDuration)
                ErrorMessage = "Max Duration must be greater than Min Duration";
            else if (_simulationParameters.NumberOfCallsOrSMS <= 0)
                ErrorMessage = "Number of Calls/SMS must be positive";
            else
                ret = true;

            return ret;
        }

        private bool CanSave(object arg)
        {
            if (_selectedClientIdNumber == null)
                return false;
            else if (_selectedLine == null)
                return false;
            else
                return true;
        }
    }
}
