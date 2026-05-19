using Eventer.Contexts.OrderContext.Entities;
using Eventer.Contexts.OrderContext.Interfaces;

namespace Eventer.Contexts.OrderContext.UseCases
{
    public class OrderGetByIdCase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderGetByIdCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order Execute(int id)
        {
            return _orderRepository.FindById(id);
        }
    }
}
