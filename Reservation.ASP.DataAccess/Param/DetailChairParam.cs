using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
    public class DetailChairParam
    {
        public int Id { get; set; }
        public Chair Chairs { get; set; }
        public Wagon Wagons { get; set;}
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public DetailChairParam() { }


        public DetailChairParam(DetailChair detailchair)
        {
            this.Id = detailchair.Id;
            this.Chairs = detailchair.Chairs;
            this.Wagons = detailchair.Wagons;
            this.CreateDate = detailchair.CreateDate;
            this.UpdateDate = detailchair.UpdateDate;
            this.DeleteDate = detailchair.DeleteDate;
            this.IsDelete = detailchair.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi

        }
    }
}
