using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
   public class Room:BaseModel
    {
        public string RoomNumber { get; set; }
        public RoomFacility RoomFacilities { get; set; }

        public Room() { }
        public Room(RoomParam _room)
        {
            this.RoomNumber = _room.RoomNumber;
            this.RoomFacilities = _room.RoomFacilities;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
            this.CreateBy = "";//isi
        }
        public virtual void Update(RoomParam _room)
        {

            this.RoomNumber = _room.RoomNumber;
            this.RoomFacilities = _room.RoomFacilities;
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
