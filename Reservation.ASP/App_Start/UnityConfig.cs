<<<<<<< HEAD
using System.Web.Mvc;
using Reservation.ASP.BussinessLogic.HotelRepository;
using Reservation.ASP.BussinessLogic.HotelService;
using Reservation.ASP.Common.Interfaces.Hotelku;
using Reservation.ASP.Common.Interfaces.Hotelku.Application;
=======
using Reservation.ASP.BussinessLogic.Repository.Kereta;
using Reservation.ASP.BussinessLogic.Repository.Kereta.Repository;
using Reservation.ASP.Common.Interfaces.Kereta;
using Reservation.ASP.Common.Interfaces.Kereta.Application;
using System.Web.Mvc;
>>>>>>> faf1ebc964bb4868c30062c7b443c449fe9b1495
using Unity;
using Unity.Mvc5;

namespace Reservation.ASP
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
<<<<<<< HEAD
            container.RegisterType<IFacilityService,FacilityService>();
            container.RegisterType<IFacilityRepository, FacilityRepository>();
            container.RegisterType<IHotelService, HotelService>();
            container.RegisterType<IHotelRepository, HotelRepository>();
=======
            container.RegisterType<IChairService, ChairService>();
            container.RegisterType<IChairRepository, ChairRepository>();
            container.RegisterType<ITrainService, TrainService>();
            container.RegisterType<ITrainRepository, TrainRepository>();
            container.RegisterType<IStationService, StationService>();
            container.RegisterType<IStationRepository, StationRepository>();
            container.RegisterType<IDistrictService, DistrictService>();
            container.RegisterType<IDistrictRepository, DistrictRepository>();
>>>>>>> faf1ebc964bb4868c30062c7b443c449fe9b1495

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}