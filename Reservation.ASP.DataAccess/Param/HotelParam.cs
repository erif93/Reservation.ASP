﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Param
{
  public class HotelParam
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Star { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string DeleteBy { get; set; }

        public HotelParam() { }


        public HotelParam(Hotel hotel)
        {
            this.Id = hotel.Id;
            this.Name = hotel.Name;
            this.Star = hotel.Star;
            this.CreateDate = hotel.CreateDate;
            this.UpdateDate = hotel.UpdateDate;
            this.DeleteDate = hotel.DeleteDate;
            this.IsDelete = hotel.IsDelete;
            this.CreateBy = "";//isi
            this.UpdateBy = "";//isi
            this.DeleteBy = "";//isi

        }
    }
}