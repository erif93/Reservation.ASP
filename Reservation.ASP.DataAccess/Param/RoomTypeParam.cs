using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
    public class RoomTypeParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DetailHotel DetailHotels { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public RoomTypeParam() { }

        public RoomTypeParam(RoomType roomtype)
        {
            this.Id = roomtype.Id;
            this.Name = roomtype.Name;
            this.Price = roomtype.Price;
            this.DetailHotels = roomtype.DetailHotels;
            this.CreateDate = roomtype.CreateDate;
            this.UpdateDate = roomtype.UpdateDate;
            this.DeleteDate = roomtype.DeleteDate;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi
        }
    }
}
