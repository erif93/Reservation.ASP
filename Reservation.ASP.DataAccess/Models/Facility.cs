using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
    public class Facility : BaseModel
    {
        public string Name { get; set; }


        public Facility() { }

        public Facility(FacilityParam _facility)
        {
            this.Name = _facility.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
            this.CreateBy = "";//isi
        }
        public virtual void Update(FacilityParam _facility)
        {
            this.Id = _facility.Id;
            this.Name = _facility.Name;
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
