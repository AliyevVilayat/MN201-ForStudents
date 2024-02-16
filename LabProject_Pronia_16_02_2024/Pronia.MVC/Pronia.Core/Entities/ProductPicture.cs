using Pronia.Core.Abstract;

namespace Pronia.Core.Entities;

public class ProductPicture : IEntity
{
    public int Id { get; set; }
    public string Path { get; set; }
    public bool IsDefault { get; set; }
}
