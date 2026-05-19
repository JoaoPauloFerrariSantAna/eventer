namespace Eventer.Contexts.OrderContext.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int? TicketId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ConfirmedAt { get; set; }
    }
}
