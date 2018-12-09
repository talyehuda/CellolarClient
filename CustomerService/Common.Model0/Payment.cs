using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Model
{
    public class Payment
    {
        public void EditPayment(Payment payment)
        {
            ClientId = payment.ClientId;
            Client = payment.Client;
            Month = payment.Month;
            TotalPayment = payment.TotalPayment;
        }
        public Payment NewPayment(int clientId, Client client, DateTime month, double totalPayment)
        {
            return new Payment
            {
                ClientId = clientId,
                Client = client,
                Month = month,
                TotalPayment = totalPayment
            };
        }

        [Key]
        public int Id { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public DateTime Month { get; set; }
        public double TotalPayment { get; set; }
    }
}