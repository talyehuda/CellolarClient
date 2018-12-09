using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class BIReport
    {
        public List<Client> MostValueClients { get; set; }
        public List<double> TopClientsLastMonthMostValue { get; set; }
        public List<Client> MostCallingToCenterClients { get; set; }
        public List<Employee> BestSellers { get; set; }
        public List<List<Client>> PotentialGrougs { get; set; }
    }
}
