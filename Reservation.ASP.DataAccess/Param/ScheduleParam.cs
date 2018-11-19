using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
   public class ScheduleParam
    {
        public int Id { get; set; }
        public Train Trains { get; set; }
        public Station Origins { get; set; }
        public Station Destinations { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public ScheduleParam() { }

        public ScheduleParam(Schedule schedule)
        {
            this.Id = schedule.Id;
            this.Trains = schedule.Trains;
            this.Origins = schedule.Origins;
            this.Destinations = schedule.Destinations;
            this.Departure = schedule.Departure;
            this.Arrival = schedule.Arrival;
            this.DepartureDate = schedule.DepartureDate;
            this.CreateDate = schedule.CreateDate;
            this.UpdateDate = schedule.UpdateDate;
            this.DeleteDate = schedule.DeleteDate;
            this.IsDelete = schedule.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi
        }
    }
}
