using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
   public class TrainReservation:BaseModel
    {
        public Rate Rates { get; set; }
        public DetailChair DetailChairs { get; set; }
        public Account Accounts { get; set; }
        public string Name { get; set; }
        public string NIK { get; set; }
        public TrainReservation()
        {

        }
        public TrainReservation(TrainReservationParam _trainreservationparam)
        {
            this.Rates = _trainreservationparam.Rates;
            this.DetailChairs = _trainreservationparam.DetailChairs;
            this.Accounts = _trainreservationparam.Accounts;
            this.Name = _trainreservationparam.Name;
            this.NIK = _trainreservationparam.NIK;
            this.CreateBy = "";//isi
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Update(TrainReservationParam _trainreservationparam)
        {
            this.Rates = _trainreservationparam.Rates;
            this.DetailChairs = _trainreservationparam.DetailChairs;
            this.Accounts = _trainreservationparam.Accounts;
            this.Name = _trainreservationparam.Name;
            this.NIK = _trainreservationparam.NIK;
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
