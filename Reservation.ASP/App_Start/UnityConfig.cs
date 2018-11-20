using Reservation.ASP.BussinessLogic.Repository.Kereta;
using Reservation.ASP.BussinessLogic.Repository.Kereta.Repository;
using Reservation.ASP.Common.Interfaces.Kereta;
using Reservation.ASP.Common.Interfaces.Kereta.Application;
using System.Web.Mvc;
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
            container.RegisterType<IChairService, ChairService>();
            container.RegisterType<IChairRepository, ChairRepository>();
            container.RegisterType<ITrainService, TrainService>();
            container.RegisterType<ITrainRepository, TrainRepository>();
            container.RegisterType<IStationService, StationService>();
            container.RegisterType<IStationRepository, StationRepository>();
            container.RegisterType<IDistrictService, DistrictService>();
            container.RegisterType<IDistrictRepository, DistrictRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}