namespace Shared.DDD
{

    public interface IAggregate<TID> : IAggregate, IEntity<TID>
    {
        
    }
    public interface IAggregate : IEntity
    {
        IReadOnlyList<IDomainEvent> DomainEvents { get; }

        IDomainEvent[] ClearDomainEvents();
    }
}
