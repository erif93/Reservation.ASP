using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;

namespace Reservation.ASP.DataAccess.Models
{
   public class Rate:BaseModel
    {
        public Schedule Schedules { get; set; }
        public TrainClass TrainClasses { get; set; }
        public double Price { get; set; }
    }
}
