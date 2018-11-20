using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
   public class HotelReservation:BaseModel
    {
        public Account Accounts { get; set; }
        public Room Rooms { get; set; }
        public string Name { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public double Total { get; set; }


        public HotelReservation() { }
        public HotelReservation(HotelReservationParam _hotelreservation)
        {
            this.Accounts = _hotelreservation.Accounts;
            this.Rooms = _hotelreservation.Rooms;
            this.Name = _hotelreservation.Name;
            this.CheckIn = _hotelreservation.CheckIn;
            this.CheckOut = _hotelreservation.CheckOut;
            this.Total = _hotelreservation.Total;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
            this.CreateBy = "";//isi
        }
        public virtual void Update(HotelReservationParam _hotelreservation)
        {
            this.Accounts = _hotelreservation.Accounts;
            this.Rooms = _hotelreservation.Rooms;
            this.Name = _hotelreservation.Name;
            this.CheckIn = _hotelreservation.CheckIn;
            this.CheckOut = _hotelreservation.CheckOut;
            this.Total = _hotelreservation.Total;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
            this.UpdateBy = "";//isi
        }
        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
            this.DeleteBy = "";
        }
    }
}
