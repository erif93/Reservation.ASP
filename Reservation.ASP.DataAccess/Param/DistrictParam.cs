using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
  public class DistrictParam
    {
        public int Id { get; set; }
        public Province Provinces { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public DistrictParam() { }


        public DistrictParam(District district)
        {
            this.Id = district.Id;
            this.Provinces = district.Provinces;
            this.Name = district.Name;
            this.CreateDate = district.CreateDate;
            this.UpdateDate = district.UpdateDate;
            this.DeleteDate = district.DeleteDate;
            this.IsDelete = district.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi
        }
    }
}
