using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
   public class WagonParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TrainClass TrainClasses { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public WagonParam() { }


        public WagonParam(Wagon wagon)
        {
            this.Id = wagon.Id;
            this.Name = wagon.Name;
            this.TrainClasses = wagon.TrainClasses;
            this.CreateDate = wagon.CreateDate;
            this.UpdateDate = wagon.UpdateDate;
            this.DeleteDate = wagon.DeleteDate;
            this.IsDelete = wagon.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi
        }
    }
}
