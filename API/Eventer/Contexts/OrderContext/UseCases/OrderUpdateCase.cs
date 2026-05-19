using Eventer.Contexts.OrderContext.Interfaces;

namespace Eventer.Contexts.OrderContext.UseCases
{
    public class OrderUpdateCase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderUpdateCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Execute(int id)
        {
            // TODO
        }
    }
}
