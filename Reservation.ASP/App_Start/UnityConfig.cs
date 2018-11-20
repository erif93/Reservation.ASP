using System.Web.Mvc;
using Reservation.ASP.BussinessLogic.HotelRepository;
using Reservation.ASP.BussinessLogic.HotelService;
using Reservation.ASP.Common.Interfaces.Hotelku;
using Reservation.ASP.Common.Interfaces.Hotelku.Application;
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
            container.RegisterType<IFacilityService,FacilityService>();
            container.RegisterType<IFacilityRepository, FacilityRepository>();
            container.RegisterType<IHotelService, HotelService>();
            container.RegisterType<IHotelRepository, HotelRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}