// See https://aka.ms/new-console-template for more information

using DiDemo;
using System.Net;


//Console.WriteLine("Podaj nazwę użytkownika: ");
//var name = Console.ReadLine();
//Console.WriteLine("Podaj adres email: ");
//var email = Console.ReadLine();
//Console.WriteLine("Podaj numer telefonu: ");
//var phoneNo = Console.ReadLine();
var repo = new UserRepository();
//var sender = new EmailSender();
var sender = new SmsSender();
var service = new UserService(sender, repo);
//var repo = new CloudUserRepository();
var user = new User
{
    Name = "Anna Nowak",
    Email = "an@wp.pl",
    PhoneNo = "565678904",
    Age = 17
};
//user.ValidateEmailaddress();
service.CreateUserAccount(user);
service.CreateUserAccount(new User { Name = "Jan Kowalski", Email = "jank@o2.pl", Age = 65, });
service.CreateUserAccount(new User { Name = "Tomasz Kwiatkowski", Email = "tkw@wp.pl", Age = 18 });


//List<User> result = new();
//foreach(var u in users)
//{
//    if(u.Age < 18)
//        result.Add(u);
//}
var users = repo.GetAll().ToList();
var result = users.Where(x => x.Age >= 18);

foreach (var u  in result)
    Console.WriteLine(u);

users.Add(new User { Name = "Andrzej Nowak", Age = 20});

Console.WriteLine("=====================");

foreach (var u in result)
    Console.WriteLine(u);

var ageSum = users.Where(x=>x.Age >= 20).Select(x => x.Age).ToList();

var nested = new List<List<int>>
{
    new List<int>{1,2,3},
    new List<int>{4,5,6}
};
var flatten = nested.SelectMany(x => x);

var u2 = users.SingleOrDefault(x => x.Address == "x");



