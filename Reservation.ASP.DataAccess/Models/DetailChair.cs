using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;

namespace Reservation.ASP.DataAccess.Models
{
   public class DetailChair:BaseModel
    {
        public Wagon Wagons { get; set; }
        public Chair Chairs { get; set; }
    }
}
