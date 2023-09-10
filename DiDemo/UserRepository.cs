namespace DiDemo;

public class UserRepository : IUserRepository
{ 
    private readonly List<User> _users = new();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public IEnumerable<User> GetAll()
    {
        return _users;
    }
}