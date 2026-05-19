using Eventer.Contexts.OrderContext.Entities;
using Eventer.Contexts.OrderContext.Interfaces;

namespace Eventer.Contexts.OrderContext.UseCases
{
    public class OrderGetAllCase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderGetAllCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> Execute()
        {
            return _orderRepository.GetAll();
        }
    }
}
