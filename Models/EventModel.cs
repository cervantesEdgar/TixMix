using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TixMix.Models
{
    internal class EventModel
    {
        public string EventListing { get; set; }
        public int EventID { get; set; }
        public DateTime EventDate { get; set; }
        public List<TicketModel> Ticket { get; set; }

        /*
         eventID : int
eventDate : DateTime
eventName : String
eventCategory : String
totalTickets: int
ticketsLeft: int
         */
    }
}
