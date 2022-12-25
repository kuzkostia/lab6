namespace lab6.Data
{
    public interface UsersInterface
    {
        List<Users> users { get; set; }
        Task GetUsers();
        Task<Users> GetUser(int ID);
        Task Create(Users users);
        Task Edit(Users users, int ID);
        Task Delete(int ID);
    }
}
