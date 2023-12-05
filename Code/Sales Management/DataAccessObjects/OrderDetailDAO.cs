using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDetailDAO
    {
        private readonly FstoreContext _context = new FstoreContext();
        public List<OrderDetailObject> GetOrderDetails()
        {
            List<OrderDetailObject> listOrderDetail = _context.OrderDetails.ToList();
            return listOrderDetail;
        }

        public List<OrderDetailObject> GetOrder(string id)
        {
            return _context.OrderDetails.Where(x => x.OrderId.ToString().Equals(id)).ToList();
        }
        public List<OrderDetailObject> ViewUserOrder(int memberid)
        {
            List<OrderDetailObject> orders = _context.OrderDetails.Where(od => _context.Orders.Any(o => o.OrderId == od.OrderId && o.MemberId == memberid))
                                            .ToList() ;
            return orders;
        }

        public void SaveOrderDetail(OrderDetailObject p)
        {
            _context.OrderDetails.Add(p);
            _context.SaveChanges();
        }

        public void DeleteOrderDetail(OrderDetailObject p)
        {
            var existingEntity = _context.OrderDetails.Find(p.OrderId, p.ProductId);
            if (existingEntity != null)
            {
                _context.OrderDetails.Remove(existingEntity);
                _context.SaveChanges();
            }
        }

        public void UpdateOrderDetail(OrderDetailObject p)
        {
            _context.OrderDetails.Update(p);
            _context.SaveChanges();
        }
    }
}
