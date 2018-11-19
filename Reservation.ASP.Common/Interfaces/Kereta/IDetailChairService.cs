using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Kereta
{
    public interface IDetailChairService
    {
        List<DetailChair> Get();
        DetailChair Get(int? id);
        bool Insert(DetailChairParam _detailchairparam);
        bool Update(DetailChairParam _detailchairparam);
        bool Delete(int? id);
    }
}
