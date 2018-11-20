using Reservation.ASP.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.ASP.Common.Interfaces.Kereta.Application
{
    public interface IDistrictRepository
    {
        List<District> Get();
        District Get(int? id);
    }
}
