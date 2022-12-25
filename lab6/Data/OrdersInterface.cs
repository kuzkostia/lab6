namespace lab6.Data
{
    public interface OrdersInterface
    {
            List<Orders> orders { get; set; }
            Task GetOrders();
            Task<Orders> GetOrder(int ID);
            Task Create(Orders orders);
            Task Delete(int ID);
    }
}

