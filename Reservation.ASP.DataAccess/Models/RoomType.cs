using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
    public class RoomType:BaseModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DetailHotel DetailHotels { get; set; }
        public RoomType() { }
        public RoomType(RoomTypeParam _roomtype)
        {
            this.Name = _roomtype.Name;
            this.Price = _roomtype.Price;
            this.DetailHotels = _roomtype.DetailHotels;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
            this.CreateBy = "";//isi
        }
        public virtual void Update(RoomTypeParam _roomtype)
        {

            this.Name = _roomtype.Name;
            this.Price = _roomtype.Price;
            this.DetailHotels = _roomtype.DetailHotels;
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
