using Reservation.ASP.Common.Interfaces.Kereta.Application;
using Reservation.ASP.DataAccess.Context;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.ASP.BussinessLogic.Repository.Kereta.Repository
{
    public class StationRepository :IStationRepository
    {
        BaseContext _context = new BaseContext();
        bool status = false;
        public bool Delete(int? id)
        {
            var getStation = _context.Stations.Find(id);
            getStation.Delete();
            _context.Entry(getStation).State = EntityState.Modified;
            var result = _context.SaveChanges();
            //_context.SaveCanges()==jumlah result yang terupdate
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Station> Get()
        {
            var c = _context.Stations.Where(x => x.IsDelete.Equals(false)).ToList();
            return c;
        }

        public Station Get(int? id)
        {
            if (id == null)
            {
                Console.Write("id is null");
            }
            Station station = _context.Stations.SingleOrDefault(x => x.Id == id);
            if (station == null)
            {
                Console.Write("Supplier has not value");
            }
            return station;
        }

        public bool Insert(StationParam _stationparam)
        {
            var push = new Station(_stationparam);
            _context.Stations.Add(push);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(StationParam _stationparam)
        {
            var getStation = Get(_stationparam.Id);
            getStation.Update(_stationparam);
            _context.Entry(getStation).State = EntityState.Modified;
            var result = _context.SaveChanges();
            //_context.SaveCanges()==jumlah result yang terupdate
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
