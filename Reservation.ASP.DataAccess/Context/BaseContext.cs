using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;

namespace Reservation.ASP.DataAccess.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("reservation") { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Chair> Chairs { get; set; }
        public DbSet<DetailChair> DetailChairs { get; set; }
        public DbSet<DetailHotel> DetailHotels { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelReservation> HotelReservations { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Regency> Regencies { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomFacility> RoomFacilities { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<TrainClass>TrainClasses { get; set; }
        public DbSet<TrainReservation> TrainReservations { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Wagon> Wagons { get; set; }
    }
}
