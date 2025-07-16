using Backend.Models;
namespace Backend.Services
{

    public class UserService
    {
        // Inizializziamo una lista di prodotto in memoria
        private readonly List<User> _users = new List<User>
        {
            new User { Id = 1, Name = "Luca ♠", Address = "Via Genova 1"},
            new User { Id = 2, Name = "FRANCESCOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO", Address = "Via Roma 2"}
        };

        // Restituisce tutti i prodotti
        //public List<User> GetAll() => _users;

        //Ciclo in modo esplicito per restituire i prodotti

        public List<User> GetAll()
        {
            List<User> result = new List<User>();
            foreach (var user in _users)
            {
                result.Add(user);
            }
            return result;
        }


        //public User? GetById(int id) => _users.FirstOrDefault(p => p.Id == id);

        public User? GetById(int id)
        {
            foreach (var user in _users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }


        // metodo Add
        // aggiunge un nuovo prodotto alla lista dei prodotti
        // 1- Calcola il prossimo ID
        // 2- Aggiunge il prodotto alla lista
        // 3- Ritorna il prodotto aggiunto
        public User Add(User newUser)
        {
            int nextId; // dichiaro una variabile per il prossimo ID
                        // se la lista dei prodotti non è vuota, calcolo il massimo ID esistente
                        // altrimenti imposto il prossimo id a 1
            if (_users.Count > 0)
            {
                int maxId = 0; // imposto il massimo ID a 0
                foreach (var p in _users)
                {
                    if (p.Id > maxId) // Se l id è maggiore del massimo ID trovato
                    {
                        maxId = p.Id; // imposto il massimo ID a quello del prodotto corrente
                    }
                }
                nextId = maxId + 1; // imposto il prossimo ID come il massimo ID trovato + 1
            }
            else
            {
                nextId = 1; // se la lista è vuota, imposto il prossimo ID a 1
            }
            newUser.Id = nextId; //assegno il prossimo ID al nuovo prodotto

            _users.Add(newUser); // aggiungo il nuovo prodotto alla lista

            return newUser; // restituisco il nuovo prodotto aggiunto
        }
        public bool Update(int id, User updateUser)
        {
            // Cerco il prodotto manualmente
            User? existing = null; // dichiaro una variabile per il prodotto esistente
                                      // cicliamo la lista dei prodotti
            foreach (var p in _users)
            {
                if (p.Id == id) // controllo se l'Id del prodotto corrisponde a quello cercato
                    existing = p; // se trovato assegno il prodotto esistente alla variabile
                break; // interrompo il cilo
            }
            // Se il prodotto non è stato trovato, restituisco false
            if (existing == null)
            {
                //non trovato
                return false; // se il prodotto non è stato trovato, restituisco false
            }
            // Sovrascrivo i campi desiderati
            existing.Name = updateUser.Name;
            existing.Address = updateUser.Address;
            return true; // restituisco true se il prodotto è stato aggiornato con successo
        }
    }
}

