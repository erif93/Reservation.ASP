using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
   public class RoomFacilityParam
    {
        public int Id { get; set; }
        public RoomType RoomTypes { get; set; }
        public Facility Facilities { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public RoomFacilityParam() { }

        public RoomFacilityParam(RoomFacility roomfacility)
        {
            this.Id = roomfacility.Id;
            this.RoomTypes = roomfacility.RoomTypes;
            this.Facilities = roomfacility.Facilities;
            this.CreateDate = roomfacility.CreateDate;
            this.UpdateDate = roomfacility.UpdateDate;
            this.DeleteDate = roomfacility.DeleteDate;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi

        }
    }
}
