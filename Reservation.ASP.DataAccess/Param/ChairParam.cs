using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
   public class ChairParam
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

        public ChairParam() { }


        public ChairParam(Chair chair)
        {
            this.Id = chair.Id;
            this.Name = chair.Name;
            this.CreateDate = chair.CreateDate;
            this.UpdateDate = chair.UpdateDate;
            this.DeleteDate = chair.DeleteDate;
            this.IsDelete = chair.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi

        }

    }
    
}
