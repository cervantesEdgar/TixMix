using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TixMix.Models
{
    internal class TicketModel
    {
        public string SeatLocation { get; set; }
        public DateTime? PurchaseDate { get; set; }  /*NUllable DateTime */
        public bool wasPurchased { get; set; }
        public int UniqueTicketID { get; set; }
       // no manches
        /*
         
         seatLocation: String
QR Code of Ticket: <PackageType>
purchaseDate?: DateTime
wasPurchased: bool
uniqueTicketID: int
*/


    }
}
