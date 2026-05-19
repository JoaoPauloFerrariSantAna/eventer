using Eventer.Contexts.OrderContext.DTOs.Requests;
using Eventer.Contexts.OrderContext.Interfaces;
using Eventer.Contexts.OrderContext.Entities;

namespace Eventer.Contexts.OrderContext.UseCases
{
    public class OrderCreateCase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderCreateCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Execute(CreateOrderRequest createOrderRequest)
        {
            try
            {
                if (createOrderRequest.EventId <= 0) throw new Exception("event id must be positive!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            var newOrder = new Order
            {
                EventId = createOrderRequest.EventId
            };

            _orderRepository.Add(newOrder);
        }
    }
}
