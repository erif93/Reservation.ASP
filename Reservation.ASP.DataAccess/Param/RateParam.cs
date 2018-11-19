using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
   public class RateParam
    {
        public int Id { get; set; }
        public Schedule Schedules { get; set; }
        public TrainClass TrainClasses { get; set; }
        public double Price { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public RateParam(){}

        public RateParam(Rate rate)
        {
            this.Id = rate.Id;
            this.Schedules = rate.Schedules;
            this.TrainClasses = rate.TrainClasses;
            this.Price = rate.Price;
            this.CreateDate = rate.CreateDate;
            this.UpdateDate = rate.UpdateDate;
            this.DeleteDate = rate.DeleteDate;
            this.IsDelete = rate.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi

        }

    }
}
