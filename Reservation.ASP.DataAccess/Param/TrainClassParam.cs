using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
    public class TrainClassParam
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

        public TrainClassParam() { }

        public TrainClassParam(TrainClass trainclass)
        {
            this.Id = trainclass.Id;
            this.Name = trainclass.Name;
            this.CreateDate = trainclass.CreateDate;
            this.UpdateDate = trainclass.UpdateDate;
            this.DeleteDate = trainclass.DeleteDate;
            this.IsDelete = trainclass.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi
        }
    }
}
