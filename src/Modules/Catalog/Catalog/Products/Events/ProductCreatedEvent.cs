


namespace Catalog.Products.Events;

public record ProductCreatedEvent(Product Product)
    : IDomainEvent
{
    public Guid EventId => throw new NotImplementedException();
}