using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
   public class RoomFacility:BaseModel
    {
        public RoomType RoomTypes { get; set; }
        public Facility Facilities { get; set; }
        public RoomFacility() { }
        public RoomFacility(RoomFacilityParam _roomfacility)
        {
            this.RoomTypes = _roomfacility.RoomTypes;
            this.Facilities = _roomfacility.Facilities;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
            this.CreateBy = "";//isi
        }
        public virtual void Update(RoomFacilityParam _roomfacility)
        {

            this.RoomTypes = _roomfacility.RoomTypes;
            this.Facilities = _roomfacility.Facilities;
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
