using Common.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Common.Model
{
    public class Client
    {
        public Client(int id, int clientIdNumber, string name, string lastName, int clientTypeId, ClientType clientType, string address, string contactNameber, int callsToCenter=0, bool deleted=false)
        {
            Id = id;
            ClientIdNumber = clientIdNumber;
            Name = name;
            LastName = lastName;
            ClientTypeId = clientTypeId;
            ClientType = clientType;
            Address = address;
            ContactNameber = contactNameber;
            CallsToCenter = callsToCenter;
            Deleted = deleted;
        }
        public Client()
        {

        }
        [Key]
        public int Id { get; set; }
        [Index(IsUnique =true)]
        public int ClientIdNumber { get; set; }//ת.ז
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [ForeignKey("ClientType")]
        public int ClientTypeId { get; set; }
        public ClientType ClientType { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ContactNameber { get; set; }
        public int CallsToCenter { get; set; } //number of times the client called the call center 
        public bool Deleted { get; private set; }
        public Client NewClient(int ClientIdNumber, string name, string lastName, int clientTypeId, string address, string contactNameber, int callsToCenter)
        {
            return new Client
            {
                ClientIdNumber = ClientIdNumber,
                Name = name,
                LastName = lastName,
                ClientTypeId = clientTypeId,
                //ClientType = clientType,
                Address = address,
                ContactNameber = contactNameber,
                CallsToCenter = callsToCenter
            };
        }
        public void EditClient(Client client)
        {
            ClientIdNumber = client.ClientIdNumber;
            Name = client.Name;
            LastName = client.LastName;
            ClientTypeId = client.ClientTypeId;
            ClientType = client.ClientType;
            Address = client.Address;
            ContactNameber = client.ContactNameber;
            CallsToCenter = client.CallsToCenter;
        }
        public void DeleteClient()
        {
            Deleted = true;
        }
        public void AnDeleteClient()
        {
            Deleted = false;
        }

        public string NameToString()
        {
            return Name + " " + LastName;
        }
    }
}