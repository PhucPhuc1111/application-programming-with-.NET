using BusinessObjects.Models;

namespace DataAccessObjects.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private OrderDAO OrderDAO = new OrderDAO();

        public List<OrderObject> getOrdersByUser(int memberid) => OrderDAO.getOrdersByUser(memberid);
        public void DeleteOrder(OrderObject p) => OrderDAO.DeleteOrder(p);

        public List<OrderObject> GetOrders() => OrderDAO.getOrders();

        public void InsertOrder(OrderObject p) => OrderDAO.InsertOrder(p);

        public void UpdateOrder(OrderObject p) => OrderDAO.UpdateOrder(p);
    }
}
