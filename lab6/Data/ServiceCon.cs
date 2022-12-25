using Microsoft.EntityFrameworkCore;

namespace lab6.Data
{
    public class ServiceCon : ServiceInterface
    {
        private readonly OrderContext _context;
        public ServiceCon(OrderContext context)
        {
            _context = context;
        }

        public List<Service> services { get; set; } = new List<Service>();

        public async Task GetService()
        {
            services = await _context.Service.ToListAsync();
        }

        public async Task<Service> GetService(int id)
        {
            var services = await _context.Service.FindAsync(id);
            if (services == null)
            {
                throw new Exception("No find this service");
            }
            return services;
        }

        public async Task Create(Service service)
        {
            await _context.Service.AddAsync(service);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Service service, int ID)
        {
            _context.Service.Update(service);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int ID)
        {
            var services = await _context.Service.FindAsync(ID);
            if (services == null)
            {
                throw new Exception("No find this service");
            }
            _context.Service.Remove(services);
            await _context.SaveChangesAsync();
        }
    }
}
