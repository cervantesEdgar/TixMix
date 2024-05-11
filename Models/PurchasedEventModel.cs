using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TixMix.Models
{
    internal class PurchasedEventModel
    {
        public int UserID { get; set; }
        public int PaymentID { get; set; }
        public int BookingID { get; set; }
        public int EventID { get; set; }
        public DateTime EventDate { get; set; }
        public string EventCategory { get; set; }
    }
}
