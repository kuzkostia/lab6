namespace lab6.Data
{
    public interface ServiceInterface
    {
        List<Service> services { get; set; }
        Task GetService();
        Task<Service> GetService(int ID);
        Task Create(Service service);
        Task Edit(Service service, int ID);
        Task Delete(int ID);
    }
}