using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
   public class RegencyParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public District Districts { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public RegencyParam() { }

        public RegencyParam(Regency regency)
        {
            this.Id = regency.Id;
            this.Name = regency.Name;
            this.Districts = regency.Districts;
            this.CreateDate = regency.CreateDate;
            this.UpdateDate = regency.UpdateDate;
            this.DeleteDate = regency.DeleteDate;
            this.IsDelete = regency.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi

        }
    }
}
