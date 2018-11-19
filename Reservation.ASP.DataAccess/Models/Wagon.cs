﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Core;

namespace Reservation.ASP.DataAccess.Models
{
    public class Wagon:BaseModel
    {
        public string Name { get; set; }
        public TrainClass TrainClasses { get; set; }
    }
}
