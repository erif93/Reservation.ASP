using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
 public class FacilityParam
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

        public FacilityParam() { }


        public FacilityParam(Facility facility)
        {
            this.Id = facility.Id;
            this.Name = facility.Name;
            this.CreateDate = facility.CreateDate;
            this.UpdateDate = facility.UpdateDate;
            this.DeleteDate = facility.DeleteDate;
            this.IsDelete = facility.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi

        }
    }
}
