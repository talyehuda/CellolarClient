using Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class Employee
    {
        public Employee(int clientIdNumber, string contactNameber, string name, string lastName, UserAuthType userAuthType)
        {
            ClientIdNumber = clientIdNumber;
            ContactNameber = contactNameber;
            Name = name;
            LastName = lastName;
            UserAuthType = userAuthType;
            NumberOfLineCustomersAdded = 0;
        }
        public Employee()
        {

        }

        [Key]
        public int Id { get; set; }
        [Index(IsUnique = true)]
        public int ClientIdNumber { get; set; }//ת.ז
        [Required]
        public string ContactNameber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public UserAuthType UserAuthType { get; set; }
        public int NumberOfLineCustomersAdded { get; set; }
        public string NameToString()
        {
            return Name + " " + LastName;
        }
        public void AddNumberOfCustomersAdded()
        {
           ++NumberOfLineCustomersAdded;
        }
    }
}
