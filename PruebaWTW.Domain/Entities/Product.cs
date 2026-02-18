namespace PruebaWTW.Domain.Entities;

public sealed class Product
{
    public new Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = default;
    public decimal Price { get; set; }
    public int Stock { get; set; } = 0;
    public DateTime CreatedAt { get; set; }
}