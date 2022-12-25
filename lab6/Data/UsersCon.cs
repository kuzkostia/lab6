using Microsoft.EntityFrameworkCore;

namespace lab6.Data
{
    public class UsersCon
    {
            private readonly OrderContext _context;
            public UsersCon(OrderContext context)
            {
                _context = context;
            }

            public List<Users> users { get; set; } = new List<Users>();

            public async Task GetUsers()
            {
                users = await _context.User.ToListAsync();
            }

            public async Task<Users> GetPerson(int ID)
            {
                var users = await _context.User.FindAsync(ID);
                if (users == null)
                {
                    throw new Exception("No find this user");
                }
                return users;
            }

            public async Task Create(Users users)
            {
                await _context.User.AddAsync(users);
                await _context.SaveChangesAsync();
            }

            public async Task Edit(Users users, int ID)
            {
                _context.User.Update(users);
                await _context.SaveChangesAsync();
            }

            public async Task Delete(int ID)
            {
                var users = await _context.User.FindAsync(ID);
                if (users == null)
                {
                    throw new Exception("No find this user");
                }
                _context.User.Remove(users);
                await _context.SaveChangesAsync();
            }
    }
}
