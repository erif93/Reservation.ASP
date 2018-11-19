using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;

namespace Reservation.ASP.DataAccess.Models
{
   public class TrainReservation:BaseModel
    {
        public Rate Rates { get; set; }
        public DetailChair DetailChairs { get; set; }
        public Account Accounts { get; set; }
        public string Name { get; set; }
        public string NIK { get; set; }

    }
}
