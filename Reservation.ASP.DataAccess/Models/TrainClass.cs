using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
    public class TrainClass:BaseModel
    {
        public string Name { get; set; }
        public TrainClass()
        {

        }
        public TrainClass(TrainClassParam _trainclassparam)
        {
            this.Name = _trainclassparam.Name;
            this.CreateBy = "";//isi
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Update(TrainClassParam _trainclassparam)
        {
            this.Name = _trainclassparam.Name;
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
