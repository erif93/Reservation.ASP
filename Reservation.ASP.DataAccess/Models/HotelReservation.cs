using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;

namespace Reservation.ASP.DataAccess.Models
{
   public class HotelReservation:BaseModel
    {
        public Account Accounts { get; set; }
        public Room Rooms { get; set; }
        public string Name { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public double Total { get; set; }

    }
}
