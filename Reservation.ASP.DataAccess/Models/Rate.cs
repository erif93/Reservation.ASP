using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
   public class Rate:BaseModel
    {
        public Schedule Schedules { get; set; }
        public TrainClass TrainClasses { get; set; }
        public double Price { get; set; }
        public Rate()
        {

        }
        public Rate(RateParam _rateparam)
        {
            this.Schedules = _rateparam.Schedules;
            this.TrainClasses = _rateparam.TrainClasses;
            this.Price = _rateparam.Price;
            this.CreateBy = "";//isi
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Update(RateParam _rateparam)
        {
            this.Schedules = _rateparam.Schedules;
            this.TrainClasses = _rateparam.TrainClasses;
            this.Price = _rateparam.Price;
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
