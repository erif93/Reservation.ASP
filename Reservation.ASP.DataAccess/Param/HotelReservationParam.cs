using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
   public class HotelReservationParam
    {
        public int Id { get; set; }
        public Account Accounts { get; set; }
        public Room Rooms { get; set; }
        public string Name { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public double Total { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public HotelReservationParam() { }


        public HotelReservationParam(HotelReservation hotelreservation)
        {
            this.Id = hotelreservation.Id;
            this.Accounts = hotelreservation.Accounts;
            this.Rooms = hotelreservation.Rooms;
            this.Name = hotelreservation.Name;
            this.CheckIn = hotelreservation.CheckIn;
            this.CheckOut = hotelreservation.CheckOut;
            this.Total = hotelreservation.Total;
            this.CreateDate = hotelreservation.CreateDate;
            this.UpdateDate = hotelreservation.UpdateDate;
            this.DeleteDate = hotelreservation.DeleteDate;
            this.IsDelete = hotelreservation.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi

        }
    }
}
