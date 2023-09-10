namespace DiDemo;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNo { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name}, mail: {Email}, wiek: {Age}";
    }
}