namespace DiDemo
{
    public interface IUserRepository
    {
        void Add(User user);

        IEnumerable<User> GetAll();
    }
}