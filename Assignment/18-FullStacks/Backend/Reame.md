## Aggiunta entità User e Purchase 

Dentro la folder Models creo il modello User.cs:

```c#
namespace Backend.Models
{
    public class Product //public indica che la classe è accessibile a tutto il programma
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
```
## Creo il Service di User 

```c#
using Backend.Models;
namespace Backend.Services
{
    public class UserService
    {
        private readonly List<User> _users= new List<User>
        {
            new User { Id = 1, Name = "wow", Address = "Via Roma 1"},
            new User { Id = 2, Name = "fra", Address = "Via Roma 2"}
        }
    }
}
```