using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
   public class Station:BaseModel
    {
        public string Name { get; set; }
        public District Districts { get; set; }
        public Station()
        {

        }
        public Station(StationParam _stationparam)
        {
            this.Name = _stationparam.Name;
            this.Districts = _stationparam.Districts;
            this.CreateBy = "";//isi
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Update(StationParam _stationparam)
        {
            this.Name = _stationparam.Name;
            this.Districts = _stationparam.Districts;
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
