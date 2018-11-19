using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;

namespace Reservation.ASP.DataAccess.Models
{
   public class DetailHotel:BaseModel
    {
        public Hotel Hotels { get; set; }
        public District Districts { get; set; }
        public string Address { get; set; }
    }
}
