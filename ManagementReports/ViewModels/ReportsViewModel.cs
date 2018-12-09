using Common.Model;
using Common.ModelToBlClient;
using LocalCommon.ViewModels;
using ManagementReports.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementReports.ViewModels
{
    public class ReportsViewModel:ViewModelBase
    {
        private BIReportsBL bIReportsBL;
        private BIReport _biReport;

        public BIReport BiReport { get => _biReport; set => SetProperty(ref _biReport, value); }

        public ReportsViewModel()
        {
            bIReportsBL = new BIReportsBL();

            ResetMessages();
            try
            {
                BiReport = bIReportsBL.GetBIReport();
            }
            catch(Exception ex)
            {
                SetErrorMessage(ex, "getting report");
            }
            /*
            BiReport = new BIReport
            {
                BestSellers = new List<Employee>
                {
                    new Employee{
                        Name="employee",
                        LastName="x"
                    },
                     new Employee{
                        Name="employee",
                        LastName="y"
                    },
                     new Employee{
                        Name="employee",
                        LastName="z"
                    }
                },
                MostCallingToCenterClients=new List<Client>
                {
                    new Client()
                    {
                        ClientIdNumber=123654321
                    },
                    new Client()
                    {
                        ClientIdNumber=514846566
                    }
                },
                MostValueClients = new List<Client>
                {
                    new Client()
                    {
                        ClientIdNumber=345345453
                    },
                    new Client()
                    {
                        ClientIdNumber=787895459
                    },
                    new Client()
                    {
                        ClientIdNumber=212121212
                    },
                    new Client()
                    {
                        ClientIdNumber=852565666
                    }
                },
                TopClientsLastMonthMostValue=new List<double>
                {
                    483.36,
                    469.63,
                    124.33
                    ,33.69
                },
                PotentialGrougs = new List<List<Client>>
                {
                    new List<Client>
                    {
                        new Client
                        {
                            ClientIdNumber=123456789
                        },
                        new Client
                        {
                            ClientIdNumber=888888555
                        },
                        new Client
                        {
                            ClientIdNumber=121256566
                        },
                        new Client
                        {
                            ClientIdNumber=464374747
                        }
                    },
                    new List<Client>
                    {
                        new Client
                        {
                            ClientIdNumber=34434333
                        },
                        new Client
                        {
                            ClientIdNumber=757334574
                        },
                        new Client
                        {
                            ClientIdNumber=126566
                        },
                        new Client
                        {
                            ClientIdNumber=33444
                        }
                    }
                }
            };
            */
        }
    }
}
