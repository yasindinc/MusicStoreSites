using MusicStoreSites.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStoreSites.Model;
using MusicStoreSites.DAL.Abstract;

namespace MusicStoreSites.BLL.Concrete
{
    class ShipperService : IShipperService
    {
        IShipperDAL _shipperDAL;
        public ShipperService(IShipperDAL shipperDAL)
        {
            _shipperDAL = shipperDAL;
        }
        public void Delete(Shipper entity)
        {
            _shipperDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public Shipper Get(int entityID)
        {
            return _shipperDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Shipper> GetAll()
        {
            return _shipperDAL.GetAll();
        }

        public void Insert(Shipper entity)
        {
            _shipperDAL.Add(entity);
        }

        public void Update(Shipper entity)
        {
            _shipperDAL.Update(entity);
        }
    }
}
