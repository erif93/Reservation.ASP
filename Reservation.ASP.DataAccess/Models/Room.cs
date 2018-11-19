using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;

namespace Reservation.ASP.DataAccess.Models
{
   public class Room:BaseModel
    {
        public string RoomNumber { get; set; }
        public RoomFacility RoomFacilities { get; set; }
    }
}
