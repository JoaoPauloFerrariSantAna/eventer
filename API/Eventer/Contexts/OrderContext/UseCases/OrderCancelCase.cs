using Eventer.Contexts.OrderContext.Interfaces;

namespace Eventer.Contexts.OrderContext.UseCases
{
    public class OrderCancelCase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderCancelCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Execute(int orderId)
        {
            // TODO
        }
    }
}
