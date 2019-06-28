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
    public class OrderService : IOrderService
    {
        IOrderDAL _orderDAL;
        public OrderService(IOrderDAL orderDAL)
        {
            _orderDAL = orderDAL;
        }
        public void Delete(Order entity)
        {
            _orderDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public Order Get(int entityID)
        {
            return _orderDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Order> GetAll()
        {
            return _orderDAL.GetAll();
        }

        public void Insert(Order entity)
        {
            _orderDAL.Add(entity);
        }

        public void Update(Order entity)
        {
            _orderDAL.Update(entity);
        }
    }
}
