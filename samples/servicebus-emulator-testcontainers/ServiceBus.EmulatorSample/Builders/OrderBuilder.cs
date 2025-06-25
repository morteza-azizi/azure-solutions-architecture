namespace ServiceBus.EmulatorSample;

public class OrderBuilder
{
    private readonly Order _order;

    private OrderBuilder()
    {
        _order = new Order { Id = Guid.NewGuid() };
    }

    public static OrderBuilder Create() => new();

    public OrderBuilder WithCustomer(string name)
    {
        _order.CustomerName = name;
        return this;
    }

    public OrderBuilder AddLaptop(int quantity = 1)
    {
        _order.Items.Add(new OrderItem
        {
            ProductName = "Laptop",
            Quantity = quantity,
            UnitPrice = 999.99m
        });
        return this;
    }

    public OrderBuilder AddMouse(int quantity = 1)
    {
        _order.Items.Add(new OrderItem
        {
            ProductName = "Mouse",
            Quantity = quantity,
            UnitPrice = 29.99m
        });
        return this;
    }

    public OrderBuilder AddKeyboard(int quantity = 1)
    {
        _order.Items.Add(new OrderItem
        {
            ProductName = "Keyboard",
            Quantity = quantity,
            UnitPrice = 59.99m
        });
        return this;
    }

    public Order Build() => _order;
} 