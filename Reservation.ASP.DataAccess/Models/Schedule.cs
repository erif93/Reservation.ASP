using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

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

        public Schedule()
        {

        }
        public Schedule(ScheduleParam _scheduleparam)
        {
            this.Trains = _scheduleparam.Trains;
            this.Origins = _scheduleparam.Origins;
            this.Destinations = _scheduleparam.Destinations;
            this.Departure = _scheduleparam.Departure;
            this.Arrival = _scheduleparam.Arrival;
            this.DepartureDate = _scheduleparam.DepartureDate;
            this.CreateBy = "";//isi
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Update(ScheduleParam _scheduleparam)
        {
            this.Trains = _scheduleparam.Trains;
            this.Origins = _scheduleparam.Origins;
            this.Destinations = _scheduleparam.Destinations;
            this.Departure = _scheduleparam.Departure;
            this.Arrival = _scheduleparam.Arrival;
            this.DepartureDate = _scheduleparam.DepartureDate;
            this.UpdateBy = "";//isi
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteBy = "";//isi
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
