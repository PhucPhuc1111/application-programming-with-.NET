using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.Repository
{
    public interface IOrderRepository
    {
        public List<OrderObject> GetOrders();
        public List<OrderObject> getOrdersByUser(int memberid);
        void InsertOrder(OrderObject p);
        void UpdateOrder(OrderObject p);
        void DeleteOrder(OrderObject p);
    }
}
