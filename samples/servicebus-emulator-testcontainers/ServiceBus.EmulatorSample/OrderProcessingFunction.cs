using Microsoft.Azure.Functions.Worker;
using ServiceBus.EmulatorSample.Services;

namespace ServiceBus.EmulatorSample;

public class OrderProcessingFunction(IOrderProcessingService orderProcessingService)
{
    [Function("OrderProcessingFunction")]
    public async Task Run(
        [ServiceBusTrigger("%QueueName%", Connection = "ServiceBusConnection")] Order order)
    {
        await orderProcessingService.ProcessOrderAsync(order);
    }
}