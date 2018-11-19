using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
    public class StationParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public District Districts { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public StationParam() { }

        public StationParam(Station station)
        {
            this.Id = station.Id;
            this.Name = station.Name;
            this.Districts = station.Districts;
            this.CreateDate = station.CreateDate;
            this.UpdateDate = station.UpdateDate;
            this.DeleteDate = station.DeleteDate;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi
        }
    }
}
