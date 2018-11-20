using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
   public class DetailHotel:BaseModel
    {
        public Hotel Hotels { get; set; }
        public District Districts { get; set; }
        public string Address { get; set; }
        public DetailHotel() { }

        public DetailHotel(DetailHotelParam _detailhotel)
        {
            this.Hotels = _detailhotel.Hotels;
            this.Districts = _detailhotel.Districts;
            this.Address = _detailhotel.Address;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
            this.CreateBy = "";//isi
        }
        public virtual void Update(DetailHotelParam _detailhotel)
        {
            this.Id = _detailhotel.Id;
            this.Hotels = _detailhotel.Hotels;
            this.Districts = _detailhotel.Districts;
            this.Address = _detailhotel.Address;
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
