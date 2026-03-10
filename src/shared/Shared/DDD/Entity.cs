

namespace Shared.DDD;

public abstract class Entity<TID> : IEntity<TID>
{
    public TID Id { get; set; }
    public DateTime? createdAt { get; set; }
    public string? createdBy { get; set; }
    public DateTime? lastModified { get; set; }
    public string? lastModifiedBy { get; set; }
}

