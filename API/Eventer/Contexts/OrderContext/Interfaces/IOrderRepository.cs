using Eventer.Contexts.OrderContext.DTOs.Requests;
using Eventer.Contexts.OrderContext.Entities;

namespace Eventer.Contexts.OrderContext.Interfaces
{
    public interface IOrderRepository
    {
        public bool IsInDatabase(int id);
        public Order FindById(int id);
        public List<Order> GetAll();
        public void Add(Order orderEntity);
        public void Delete(int id);
        public void PayOrder(int orderId);
        public void CancelOrder(int orderId);
    }
}
