using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
   public class ProvinceParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public ProvinceParam() { }


        public ProvinceParam(Province province)
        {
            this.Id = province.Id;
            this.Name = province.Name;
            this.CreateDate = province.CreateDate;
            this.UpdateDate = province.UpdateDate;
            this.DeleteDate = province.DeleteDate;
            this.IsDelete = province.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi

        }
    }
}
