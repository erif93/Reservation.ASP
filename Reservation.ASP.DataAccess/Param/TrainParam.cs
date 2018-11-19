using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
   public class TrainParam
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

        public TrainParam() { }

        public TrainParam(Train train)
        {
            this.Id = train.Id;
            this.Name = train.Name;
            this.CreateDate = train.CreateDate;
            this.UpdateDate = train.UpdateDate;
            this.DeleteDate = train.DeleteDate;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi
        }
    }
}
