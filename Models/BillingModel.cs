using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TixMix.Models
{
    internal class BillingModel
    {
        public float PaymentAmount { get; set; }
        public float SecureTransactionID { get; set; }
        public string CardInfo { get; set; }
        public int PaymentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public int BookingID { get; set; }

        public BillingModel(float paymentAmount, float secureTransactionID, string cardInfo, int paymentID, DateTime paymentDate, int bookingID)
        {
            PaymentAmount = paymentAmount;
            SecureTransactionID = secureTransactionID;
            CardInfo = cardInfo;
            PaymentID = paymentID;
            PaymentDate = paymentDate;
            BookingID = bookingID;
        }

    }
}