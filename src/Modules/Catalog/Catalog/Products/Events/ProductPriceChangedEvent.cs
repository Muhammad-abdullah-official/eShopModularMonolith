



namespace Catalog.Products.Events;

public record ProductPriceChangedEvent(Product Product)
: IDomainEvent
{
    public Guid EventId => throw new NotImplementedException();
}