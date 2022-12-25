using Microsoft.EntityFrameworkCore;

namespace lab6.Data
{
    public class OrdersCon : OrdersInterface
    {
        private readonly OrderContext _context;
        public OrdersCon(OrderContext context)
        {
            _context = context;
        }

        public List<Orders> orders { get; set; } = new List<Orders>();

        public async Task GetOrders()
        {
            orders = await _context.Order.Include(prop => prop.Users).Include(prop => prop.Service).ToListAsync();
        }

        public async Task<Orders> GetOrder(int ID)
        {
            var order = await _context.Order.FindAsync(ID);
            if (order == null)
            {
                throw new Exception("No find this order");
            }
            return order;
        }

        public async Task Create(Orders orders)
        {
            if (orders.UserID != 0 && orders.ServiceID != 0)
            {
                await _context.Order.AddAsync(orders);
                await _context.SaveChangesAsync();
            }

        }

        public async Task Delete(int ID)
        {
            var order = await _context.Order.FindAsync(ID);
            if (order == null)
            {
                throw new Exception("No find this order");
            }
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
        }
    }
}
