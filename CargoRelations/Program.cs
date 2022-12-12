using CargoRelations.Models;

class Program
{
    public static void Main(string[] args)
    {
        #region Items
        Item item = new Item
        {
            Id = 43,
            Name = "Iron",
            Price = 50.99M,
            Count = 2
        };
        Item item2 = new Item
        {
            Id = 33,
            Name = "TV",
            Price = 1099.99M,
            Count = 1
        };
        Item item3 = new Item
        {
            Id = 33,
            Name = "Mouse",
            Price = 30.99M,
            Count = 3
        };
        Item item4 = new Item
        {
            Id = 33,
            Name = "Headphones",
            Price = 64.45M,
            Count = 1
        };
        #endregion

        #region Order Items
        OrderItems orderItems = new OrderItems
        {
            OrderId = 12,
            Item = item
        };
        OrderItems orderItems2 = new OrderItems
        {
            OrderId = 12,
            Item = item2
        };
        OrderItems orderItems3 = new OrderItems
        {
            OrderId = 14,
            Item = item3
        };
        OrderItems orderItems4 = new OrderItems
        {
            OrderId = 14,
            Item = item4
        };
        #endregion

        #region Order
        Order order = new Order
        {
            Id = 12,
            OrderDate = DateTime.Now,
            Status = "Ongoing",
            ClientId = 22,
            OrderItems = new List<OrderItems> { orderItems, orderItems2 }
        };
        Order order2 = new Order
        {
            Id = 14,
            OrderDate = DateTime.Now,
            Status = "Arrived",
            ClientId = 22,
            OrderItems = new List<OrderItems> { orderItems3, orderItems4 }
        };
        #endregion

        #region Client
        Client client = new Client
        {
            Id = 22,
            FullName = "Lorem Man",
            Orders = new List<Order>() { order, order2 }
        };
        #endregion

        //Sum total of Order 12
        decimal sumTotal = 0;
        foreach (var oItem in order.OrderItems)
        {
            sumTotal += oItem.Item.Price * oItem.Item.Count;
        }
        //Console.WriteLine(sumTotal);

        //Sum total of Clients Orders
        decimal sumTotal2 = 0;
        foreach (var o in client.Orders)
        {
            foreach (var oItem in o.OrderItems)
            {
                sumTotal2 += oItem.Item.Price * oItem.Item.Count;
            }
        }
        Console.WriteLine(sumTotal2);
    }
}