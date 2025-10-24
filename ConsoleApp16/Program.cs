using Task1;

UserService userService = new UserService();

User newUser1 = new User(4, "Osman", "osman@email.com");
userService.Create(newUser1, out bool created);

if (created)
{
    Console.WriteLine($"User yaradıldı, Id: {newUser1.id}");
}

User newUser2 = new User(6, "Osman", "osman@email.com");
userService.Create(newUser2, out bool created2);

if (created2)
{
    Console.WriteLine($"User yaradıldı, Id: {newUser2.id}");

}

User[] Users = userService.GetAll();

foreach (User user in Users)
{
    Console.WriteLine(user);
}


