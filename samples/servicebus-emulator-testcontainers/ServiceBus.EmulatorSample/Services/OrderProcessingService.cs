using Microsoft.Extensions.Logging;

namespace ServiceBus.EmulatorSample.Services;

public interface IOrderProcessingService
{
    Task PublishOrderAsync(Order order);
    Task ProcessOrderAsync(Order order);
}

public class OrderProcessingService(MessageSender messageSender, ILogger<OrderProcessingService> logger) : IOrderProcessingService
{
    public async Task PublishOrderAsync(Order order)
    {
        logger.LogInformation("Publishing order {OrderId} for customer {CustomerName}", 
            order.Id, order.CustomerName);
        
        await messageSender.SendOrderAsync(order);
    }

    public async Task ProcessOrderAsync(Order order)
    {
        // Template method - no logic
        await Task.CompletedTask;
    }
} 