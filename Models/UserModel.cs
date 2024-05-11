using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TixMix.Models
{
    internal class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<EventModel> PurchasedEvent { get; set; }
        public string UserType { get; set; }
        public string UserEmail { get; set; }
    }
}
