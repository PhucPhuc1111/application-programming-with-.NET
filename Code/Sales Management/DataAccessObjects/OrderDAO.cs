
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObjects
{
    public class OrderDAO
    {
        private readonly FstoreContext _context = new FstoreContext();
        public List<OrderObject> getOrders()
        {
            var orders = _context.Orders.ToList();
            return orders;
        }

        public List<OrderObject> getOrdersByUser(int memberid)
        {
            return _context.Orders.Where(x => x.MemberId == memberid).ToList();
        }
        public void InsertOrder(OrderObject o)
        {
            _context.Orders.Add(o);
            _context.SaveChanges();
        }

        public void DeleteOrder(OrderObject o)
        {
            var existingEntity = _context.Orders.Find(o.OrderId);
            if (existingEntity != null)
            {
                _context.Orders.Remove(existingEntity);
                _context.SaveChanges();
            }
        }

        public void UpdateOrder(OrderObject o)
        {
            _context.Orders.Update(o);
            _context.SaveChanges();
        }
    }
}
