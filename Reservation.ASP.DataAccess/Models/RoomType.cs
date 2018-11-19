using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;

namespace Reservation.ASP.DataAccess.Models
{
    public class RoomType:BaseModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DetailHotel DetailHotels { get; set; }
    }
}
