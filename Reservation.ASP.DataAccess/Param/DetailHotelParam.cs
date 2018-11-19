using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
   public class DetailHotelParam
    {
        public int Id { get; set; }
        public Hotel Hotels { get; set; }
        public District Districts { get; set; }
        public string Address { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public DetailHotelParam() { }


        public DetailHotelParam(DetailHotel detailhotel)
        {
            this.Id = detailhotel.Id;
            this.Hotels = detailhotel.Hotels;
            this.Address = detailhotel.Address;
            this.IsDelete = detailhotel.IsDelete;
            this.CreateDate = detailhotel.CreateDate;
            this.UpdateDate = detailhotel.UpdateDate;
            this.DeleteDate = detailhotel.DeleteDate;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi

        }
    }
}
