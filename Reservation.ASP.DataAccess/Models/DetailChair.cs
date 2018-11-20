using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
   public class DetailChair:BaseModel
    {
        public Wagon Wagons { get; set; }
        public Chair Chairs { get; set; }
        public DetailChair()
        {

        }
        public DetailChair(DetailChairParam _detailchairparam)
        {
            this.Wagons = _detailchairparam.Wagons;
            this.Chairs = _detailchairparam.Chairs;
            this.CreateBy = "";//isi
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Update(DetailChairParam _detailchairparam)
        {
            this.Wagons = _detailchairparam.Wagons;
            this.Chairs = _detailchairparam.Chairs;
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
