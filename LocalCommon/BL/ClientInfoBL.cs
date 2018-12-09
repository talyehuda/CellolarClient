
using LocalCommon.BL;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalCommon.DAL;

namespace LocalCommon.BL
{
    public class ClientInfoBL:BLBase
    {
        public ClientInfoBL()
        {
            apiAccess = new WebAPIAccess("client");
        }

        public List<int> GetClientIdNumbers()
        {
            return GetAPIData<List<int>>("getlistclientsidnumber");
        }

        public Client GetClientByIdNumber(int clientIdNumber)
        {
            return GetAPIData<Client>($"getclientbyid?clientidnumber={clientIdNumber}");
        }

        public void AddClient(Client client)
        {
            PostAPIData("addclient", client);
        }

        public void EditClient(Client client)
        {
            PostAPIData("editclient",client);
        }

        public void DeleteClient(Client client)
        {
            GetAPIData($"removeclient?id={client.Id}");
        }

        public List<ClientType> GetClientTypes()
        {
            return GetAPIData<List<ClientType>>("getlistclienttype");
        }


    }
}
