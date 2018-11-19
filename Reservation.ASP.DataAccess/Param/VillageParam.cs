using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
    public class VillageParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Regency Regencies { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public VillageParam() { }


        public VillageParam(Village village)
        {
            this.Id = village.Id;
            this.Name = village.Name;
            this.Regencies = village.Regencies;
            this.CreateDate = village.CreateDate;
            this.UpdateDate = village.UpdateDate;
            this.DeleteDate = village.DeleteDate;
            this.IsDelete = village.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi
        }
    }
}
