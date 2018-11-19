namespace Reservation.ASP.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingFirstMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        NIK = c.String(),
                        Level = c.Int(nullable: false),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Chairs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DetailChairs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Chairs_Id = c.Int(),
                        Wagons_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chairs", t => t.Chairs_Id)
                .ForeignKey("dbo.Wagons", t => t.Wagons_Id)
                .Index(t => t.Chairs_Id)
                .Index(t => t.Wagons_Id);
            
            CreateTable(
                "dbo.Wagons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        TrainClasses_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TrainClasses", t => t.TrainClasses_Id)
                .Index(t => t.TrainClasses_Id);
            
            CreateTable(
                "dbo.TrainClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DetailHotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Districts_Id = c.Int(),
                        Hotels_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Districts", t => t.Districts_Id)
                .ForeignKey("dbo.Hotels", t => t.Hotels_Id)
                .Index(t => t.Districts_Id)
                .Index(t => t.Hotels_Id);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Provinces_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provinces", t => t.Provinces_Id)
                .Index(t => t.Provinces_Id);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Star = c.Int(nullable: false),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HotelReservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        Total = c.Double(nullable: false),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Accounts_Id = c.Int(),
                        Rooms_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Accounts_Id)
                .ForeignKey("dbo.Rooms", t => t.Rooms_Id)
                .Index(t => t.Accounts_Id)
                .Index(t => t.Rooms_Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomNumber = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        RoomFacilities_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoomFacilities", t => t.RoomFacilities_Id)
                .Index(t => t.RoomFacilities_Id);
            
            CreateTable(
                "dbo.RoomFacilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Facilities_Id = c.Int(),
                        RoomTypes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facilities", t => t.Facilities_Id)
                .ForeignKey("dbo.RoomTypes", t => t.RoomTypes_Id)
                .Index(t => t.Facilities_Id)
                .Index(t => t.RoomTypes_Id);
            
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        DetailHotels_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DetailHotels", t => t.DetailHotels_Id)
                .Index(t => t.DetailHotels_Id);
            
            CreateTable(
                "dbo.Rates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Schedules_Id = c.Int(),
                        TrainClasses_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schedules", t => t.Schedules_Id)
                .ForeignKey("dbo.TrainClasses", t => t.TrainClasses_Id)
                .Index(t => t.Schedules_Id)
                .Index(t => t.TrainClasses_Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Departure = c.String(),
                        Arrival = c.String(),
                        DepartureDate = c.DateTime(nullable: false),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Destinations_Id = c.Int(),
                        Origins_Id = c.Int(),
                        Trains_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stations", t => t.Destinations_Id)
                .ForeignKey("dbo.Stations", t => t.Origins_Id)
                .ForeignKey("dbo.Trains", t => t.Trains_Id)
                .Index(t => t.Destinations_Id)
                .Index(t => t.Origins_Id)
                .Index(t => t.Trains_Id);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Districts_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Districts", t => t.Districts_Id)
                .Index(t => t.Districts_Id);
            
            CreateTable(
                "dbo.Trains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Regencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Districts_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Districts", t => t.Districts_Id)
                .Index(t => t.Districts_Id);
            
            CreateTable(
                "dbo.TrainReservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NIK = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Accounts_Id = c.Int(),
                        DetailChairs_Id = c.Int(),
                        Rates_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Accounts_Id)
                .ForeignKey("dbo.DetailChairs", t => t.DetailChairs_Id)
                .ForeignKey("dbo.Rates", t => t.Rates_Id)
                .Index(t => t.Accounts_Id)
                .Index(t => t.DetailChairs_Id)
                .Index(t => t.Rates_Id);
            
            CreateTable(
                "dbo.Villages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        DeleteBy = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Regencies_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regencies", t => t.Regencies_Id)
                .Index(t => t.Regencies_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Villages", "Regencies_Id", "dbo.Regencies");
            DropForeignKey("dbo.TrainReservations", "Rates_Id", "dbo.Rates");
            DropForeignKey("dbo.TrainReservations", "DetailChairs_Id", "dbo.DetailChairs");
            DropForeignKey("dbo.TrainReservations", "Accounts_Id", "dbo.Accounts");
            DropForeignKey("dbo.Regencies", "Districts_Id", "dbo.Districts");
            DropForeignKey("dbo.Rates", "TrainClasses_Id", "dbo.TrainClasses");
            DropForeignKey("dbo.Rates", "Schedules_Id", "dbo.Schedules");
            DropForeignKey("dbo.Schedules", "Trains_Id", "dbo.Trains");
            DropForeignKey("dbo.Schedules", "Origins_Id", "dbo.Stations");
            DropForeignKey("dbo.Schedules", "Destinations_Id", "dbo.Stations");
            DropForeignKey("dbo.Stations", "Districts_Id", "dbo.Districts");
            DropForeignKey("dbo.HotelReservations", "Rooms_Id", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "RoomFacilities_Id", "dbo.RoomFacilities");
            DropForeignKey("dbo.RoomFacilities", "RoomTypes_Id", "dbo.RoomTypes");
            DropForeignKey("dbo.RoomTypes", "DetailHotels_Id", "dbo.DetailHotels");
            DropForeignKey("dbo.RoomFacilities", "Facilities_Id", "dbo.Facilities");
            DropForeignKey("dbo.HotelReservations", "Accounts_Id", "dbo.Accounts");
            DropForeignKey("dbo.DetailHotels", "Hotels_Id", "dbo.Hotels");
            DropForeignKey("dbo.DetailHotels", "Districts_Id", "dbo.Districts");
            DropForeignKey("dbo.Districts", "Provinces_Id", "dbo.Provinces");
            DropForeignKey("dbo.DetailChairs", "Wagons_Id", "dbo.Wagons");
            DropForeignKey("dbo.Wagons", "TrainClasses_Id", "dbo.TrainClasses");
            DropForeignKey("dbo.DetailChairs", "Chairs_Id", "dbo.Chairs");
            DropIndex("dbo.Villages", new[] { "Regencies_Id" });
            DropIndex("dbo.TrainReservations", new[] { "Rates_Id" });
            DropIndex("dbo.TrainReservations", new[] { "DetailChairs_Id" });
            DropIndex("dbo.TrainReservations", new[] { "Accounts_Id" });
            DropIndex("dbo.Regencies", new[] { "Districts_Id" });
            DropIndex("dbo.Stations", new[] { "Districts_Id" });
            DropIndex("dbo.Schedules", new[] { "Trains_Id" });
            DropIndex("dbo.Schedules", new[] { "Origins_Id" });
            DropIndex("dbo.Schedules", new[] { "Destinations_Id" });
            DropIndex("dbo.Rates", new[] { "TrainClasses_Id" });
            DropIndex("dbo.Rates", new[] { "Schedules_Id" });
            DropIndex("dbo.RoomTypes", new[] { "DetailHotels_Id" });
            DropIndex("dbo.RoomFacilities", new[] { "RoomTypes_Id" });
            DropIndex("dbo.RoomFacilities", new[] { "Facilities_Id" });
            DropIndex("dbo.Rooms", new[] { "RoomFacilities_Id" });
            DropIndex("dbo.HotelReservations", new[] { "Rooms_Id" });
            DropIndex("dbo.HotelReservations", new[] { "Accounts_Id" });
            DropIndex("dbo.Districts", new[] { "Provinces_Id" });
            DropIndex("dbo.DetailHotels", new[] { "Hotels_Id" });
            DropIndex("dbo.DetailHotels", new[] { "Districts_Id" });
            DropIndex("dbo.Wagons", new[] { "TrainClasses_Id" });
            DropIndex("dbo.DetailChairs", new[] { "Wagons_Id" });
            DropIndex("dbo.DetailChairs", new[] { "Chairs_Id" });
            DropTable("dbo.Villages");
            DropTable("dbo.TrainReservations");
            DropTable("dbo.Regencies");
            DropTable("dbo.Trains");
            DropTable("dbo.Stations");
            DropTable("dbo.Schedules");
            DropTable("dbo.Rates");
            DropTable("dbo.RoomTypes");
            DropTable("dbo.RoomFacilities");
            DropTable("dbo.Rooms");
            DropTable("dbo.HotelReservations");
            DropTable("dbo.Facilities");
            DropTable("dbo.Hotels");
            DropTable("dbo.Provinces");
            DropTable("dbo.Districts");
            DropTable("dbo.DetailHotels");
            DropTable("dbo.TrainClasses");
            DropTable("dbo.Wagons");
            DropTable("dbo.DetailChairs");
            DropTable("dbo.Chairs");
            DropTable("dbo.Accounts");
        }
    }
}
