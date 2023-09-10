namespace DiDemo;

public class UserService : IUserService
{
    private readonly ISender _msgSender;
    private readonly IUserRepository _userRepository;

    public UserService(ISender msgSender, IUserRepository userRepository)
    {
        _userRepository = userRepository;
        _msgSender = msgSender;
    }

    public void CreateUserAccount(User user)
    {
        _userRepository.Add(user);
        _msgSender.Send(user, "Utworzono konto");
    }
}