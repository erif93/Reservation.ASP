using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
    public class Wagon:BaseModel
    {
        public string Name { get; set; }
        public TrainClass TrainClasses { get; set; }
        public Wagon(){}
        public Wagon(WagonParam _wagonparam)
        {
            this.Name = _wagonparam.Name;
            this.TrainClasses = _wagonparam.TrainClasses;
            this.CreateBy = "";//isi
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Update(WagonParam _wagonparam)
        {
            this.Name = _wagonparam.Name;
            this.TrainClasses = _wagonparam.TrainClasses;
            this.UpdateBy = "";//isi
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteBy = "";//isi
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}