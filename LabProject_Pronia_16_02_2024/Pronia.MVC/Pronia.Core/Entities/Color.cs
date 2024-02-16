using Pronia.Core.Abstract;

namespace Pronia.Core.Entities;

public class Color : BaseEntity, IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}
