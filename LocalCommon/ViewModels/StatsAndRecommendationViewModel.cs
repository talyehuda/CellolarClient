using Common.Model;
using LocalCommon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LocalCommon.BL;
using Common.ModelToBlClient.OptimalPackage;

namespace LocalCommon.ViewModels
{
    public class StatsAndRecommendationViewModel : ViewModelBase
    {
        private ClientInfoBL clientInfoBL;
        private LineInfoBL lineInfoBL;
        private OptimalPackageBL clientStatsBL;

        private DelegateCommand _calculateCommand;
        public ICommand CalculateCommand { get => _calculateCommand; }
        
        private int? _clientId;
        private IList<Line> _lines;
        private Line _selectedLine;
        private OptimalPackage _clientStats;
        

        public StatsAndRecommendationViewModel()
        {
            clientInfoBL = new ClientInfoBL();
            lineInfoBL = new LineInfoBL();
            clientStatsBL = new OptimalPackageBL();

            _calculateCommand = new DelegateCommand(OnCalculate, CanCalculate);

        }


        public int? ClientId
        {
            get => _clientId;
            set
            {
                SetProperty(ref _clientId, value);

                ResetMessages();
                if (ClientId != null)
                {
                    try
                    {
                        Lines = lineInfoBL.GetClientLines((int)_clientId);
                    }
                    catch (Exception ex)
                    {
                        SetErrorMessage(ex, "loading client");
                        return;
                    }
                    SelectedLine = null;
                }
                else
                {
                    Lines = null;
                }

                _calculateCommand.InvokeCanExecuteChanged();
            }
        }
        public IList<Line> Lines { get => _lines; set => SetProperty(ref _lines, value); }
        public Line SelectedLine
        {
            get => _selectedLine;
            set
            {
                SetProperty(ref _selectedLine, value);
                _calculateCommand.InvokeCanExecuteChanged();
            }
        }

        public OptimalPackage ClientStats { get => _clientStats; set => SetProperty(ref _clientStats, value); }

        private bool CanCalculate(object arg)
        {
            if (_clientId == null)
                return false;
            else if (_selectedLine == null)
                return false;
            else
                return true;
        }

        private void OnCalculate(object obj)
        {
            ResetMessages();
            try
            {
                ClientStats = clientStatsBL.GetClientOptimalPackage(SelectedLine.Id);
                InfoMessage = "Done";
            }
            catch (Exception ex)
            {
                SetErrorMessage(ex,"calculating");
            }
            
        }
    }

   
}
