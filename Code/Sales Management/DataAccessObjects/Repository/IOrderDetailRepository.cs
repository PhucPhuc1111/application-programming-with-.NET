using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.Repository
{
    public interface IOrderDetailRepository
    {
        public List<OrderDetailObject> GetOrderDetails();
        public List<OrderDetailObject> ViewUserOrder(int memberid);
        void InsertOrderDetail(OrderDetailObject OrderDetail);
        void UpdateOrderDetail(OrderDetailObject OrderDetail);
        void DeleteOrderDetail(OrderDetailObject OrderDetail);
        public List<OrderDetailObject> GetOrder(string id);
    }
}
