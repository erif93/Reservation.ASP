using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.DataAccess.Models
{
   public class Chair:BaseModel
    {
        public string Name { get; set; }
        public Chair()
        {

        }
        public Chair(ChairParam _chairparam)
        {
            this.Name = _chairparam.Name;
            this.CreateBy = "";//isi
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Update(ChairParam _chairparam)
        {
            this.Name = _chairparam.Name;
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
