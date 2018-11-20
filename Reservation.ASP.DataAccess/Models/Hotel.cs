using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
  public class Hotel:BaseModel
    {
        public string Name { get; set; }
        public int Star { get; set; }
        public Hotel() { }

        public Hotel(HotelParam _hotel)
        {
            this.Name = _hotel.Name;
            this.Star = _hotel.Star;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
            this.CreateBy = "";//isi
        }
        public virtual void Update(HotelParam _hotel)
        {
            this.Id = _hotel.Id;
            this.Name = _hotel.Name;
            this.Star = _hotel.Star;
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
