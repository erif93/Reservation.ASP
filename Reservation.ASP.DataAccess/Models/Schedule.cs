using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;

namespace Reservation.ASP.DataAccess.Models
{
   public class Schedule:BaseModel
    {
        public Train Trains { get; set; }
        public Station Origins { get; set; }
        public Station Destinations { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public DateTime DepartureDate { get; set; }

    }
}
