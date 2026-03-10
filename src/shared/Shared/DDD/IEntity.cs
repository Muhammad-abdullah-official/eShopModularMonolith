 
namespace Shared.DDD;

public interface IEntity<TId> : IEntity // generic interface for entities with a specific type of identifier
{
    public TId Id { get; set; }
}
    public interface IEntity
    {
        public DateTime? createdAt { get; set; }
        public string? createdBy { get; set; }
        public DateTime? lastModified { get; set; }
        public string? lastModifiedBy { get; set; }
    }

