namespace Task1
{
    internal class UserService
    {
        private User[] _users;

        public UserService()
        {
            _users = new User[]
            {
                new User(1, "Ali","ali@email.com"),
                new User(2, "Mehemmed","mehemmmed@email.com"),
                new User(3, "Zohrab","zohrab@email.com"),
                new User(4, "Ehmed","ehmed@email.com"),
                new User(5, "Kenan","kenan@email.com"),
            };
        }
        public void Create(User user, out bool IsLogged)
        {
            
            for (int i = 0; i < _users.Length; i++)
            {   
                if(user.id == _users[i].id)
                {
                    Console.WriteLine("User artiq movcuddur");
                    IsLogged = false;
                    return;
                }
                

            }
            Array.Resize(ref _users, _users.Length+1);
            _users[_users.Length-1] = user;
            IsLogged = true;

        }

        public User GetById(int id)
        {
            foreach (var user in _users)
            {
                if(user.id == id) return user;  
            }
            return null;
        }

        public User[] GetAll()
        {
            return _users;
        }

        public void Delete(int id)
        {
            int idx = -1;
            for (int i = 0;i<_users.Length;i++)
            {
                if (_users[i].id == id)
                {
                    break;
                }
            }
            if(idx == -1)
            {
                Console.WriteLine("User tapilmadi");
            }
            for (int i = idx; i < _users.Length; i++)
            {
                _users[i] = _users[i + 1];
            }
            Array.Resize(ref _users, _users.Length - 1);
            
        }
    }
    public class User
    {
        public int id { get; }
        public string name { get; set; }

        public string email { get; set; }

        public User(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }
        public override string ToString()
        {
            return $"Id: {id}, Name: {name}, Email: {email}";
        }

    }
}
