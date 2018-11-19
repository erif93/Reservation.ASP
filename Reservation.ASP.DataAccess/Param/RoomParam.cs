using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
    public class RoomParam
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public RoomFacility RoomFacilities { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public RoomParam() { }

        public RoomParam(Room room)
        {
            this.Id = room.Id;
            this.RoomNumber = room.RoomNumber;
            this.RoomFacilities = room.RoomFacilities;
            this.CreateDate = room.CreateDate;
            this.UpdateDate = room.UpdateDate;
            this.DeleteDate = room.DeleteDate;
            this.IsDelete = room.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi

        }
    }
}
