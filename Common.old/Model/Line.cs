using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Model
{
    public class Line
    {
        public Line(int id, int clientId, Client client, string number, Status status, int? packageId, Package package, bool deleted)
        {
            Id = id;
            ClientId = clientId;
            Client = client;
            Number = number;
            Status = status;
            PackageId = packageId;
            Package = package;
            Deleted = deleted;
        }
        public Line()
        {

        }
        [Key]
        public int Id { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string Number { get; set; }
        public Status Status { get; set; }
        [ForeignKey("Package")]
        public int? PackageId { get; set; }
        public Package Package { get; set; }
        public bool Deleted { get; private set; }
        public void EditLine(Line line)
        {
            ClientId = line.ClientId ;
            Client =line.Client ;
            Number =line.Number ;
            Status =line.Status ;
            PackageId =line.PackageId ;
            Package =line.Package ;
        }
        public Line NewLine(int clientId, Client client, string number, Status status, int? packageId, Package package)
        {
            return new Line {
                ClientId = clientId,
            Client = client,
            Number = number,
            Status = status,
            PackageId = packageId,
            Package = package};
        }
        public void DeleteLine()
        {
            Deleted = true;
        }
    }
}
