using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
        public void DeleteOrderDetail(OrderDetailObject OrderDetail)=> orderDetailDAO.DeleteOrderDetail(OrderDetail);

        public List<OrderDetailObject> GetOrder(string id) => orderDetailDAO.GetOrder(id);

        public List<OrderDetailObject> GetOrderDetails() => orderDetailDAO.GetOrderDetails();

        public void InsertOrderDetail(OrderDetailObject OrderDetail) => orderDetailDAO.SaveOrderDetail(OrderDetail);

        public void UpdateOrderDetail(OrderDetailObject OrderDetail) => orderDetailDAO.UpdateOrderDetail(OrderDetail);

        public List<OrderDetailObject> ViewUserOrder(int memberid) => orderDetailDAO.ViewUserOrder(memberid);
    }
}
