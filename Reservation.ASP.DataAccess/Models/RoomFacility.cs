using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;

namespace Reservation.ASP.DataAccess.Models
{
   public class RoomFacility:BaseModel
    {
        public RoomType RoomTypes { get; set; }
        public Facility Facilities { get; set; }
    }
}
