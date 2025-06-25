using System.Text.Json.Serialization;

namespace ServiceBus.EmulatorSample;

public class Order
{
    public Guid Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public List<OrderItem> Items { get; set; } = new();
    public decimal TotalPrice { get; set; }
    public decimal DiscountApplied { get; set; }
    public decimal FinalPrice { get; set; }
    public DateTime ProcessedAt { get; set; }
}

public class OrderItem
{
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
} 