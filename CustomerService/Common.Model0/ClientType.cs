using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class ClientType
    {

        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; }
        public double MinutePrice { get; set; }
        public double SMSPrice { get; set; }

        public void EditClientType(ClientType clientType)
        {
            TypeName = clientType.TypeName;
            MinutePrice = clientType.MinutePrice;
            SMSPrice =clientType.SMSPrice;
        }
        public ClientType NewClientType(string typeName, double minutePrice, double sMSPrice)
        {
            return new ClientType
            {
                TypeName = typeName,
                MinutePrice = minutePrice,
                SMSPrice = sMSPrice
            };
        }
    }
}
