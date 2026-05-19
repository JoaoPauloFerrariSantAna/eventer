using Eventer.Contexts.OrderContext.Interfaces;

namespace Eventer.Contexts.OrderContext.UseCases
{
    public class OrderPayCase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderPayCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Execute(int orderId)
        {
            // TODO
        }
    }
}
