using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
    public class TrainReservationParam
    {
        public int Id { get; set; }
        public Rate Rates { get; set; }
        public DetailChair DetailChairs { get; set; }
        public Account Accounts { get; set; }
        public string Name { get; set; }
        public string NIK { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public TrainReservationParam() { }


        public TrainReservationParam(TrainReservation trainreservation)
        {
            this.Id = trainreservation.Id;
            this.Rates = trainreservation.Rates;
            this.DetailChairs = trainreservation.DetailChairs;
            this.Accounts = trainreservation.Accounts;
            this.Name = trainreservation.Name;
            this.NIK = trainreservation.NIK;
            this.CreateDate = trainreservation.CreateDate;
            this.UpdateDate = trainreservation.UpdateDate;
            this.DeleteDate = trainreservation.DeleteDate;
            this.IsDelete = trainreservation.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi
        }
    }
}