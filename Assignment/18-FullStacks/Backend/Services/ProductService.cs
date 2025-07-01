using Backend.Models;
namespace Backend.Services
{

    public class ProductService
    {
        // Inizializziamo una lista di prodotto in memoria
        private readonly List<Product> _products = new() // Definisco privata la Lista di prodotti perché vorrei che sia accessibile solo alla stessa classe
        {
            new Product { Id = 1, Name = "Penna", Price = 1.20M, Quantita = 1 },
            new Product { Id = 2, Name = "Quaderno", Price = 2.50M, Quantita = 2 },
            new Product { Id = 3, Name = "Astuccio", Price = 5.00M, Quantita = 3 }
        };

        // Restituisce tutti i prodotti
        //public List<Product> GetAll() => _products;

        //Ciclo in modo esplicito per restituire i prodotti

        public List<Product> GetAll()
        {
            List<Product> result = new List<Product>();
            foreach (var product in _products)
            {
                result.Add(product);
            }
            return result;
        }


        //public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public Product? GetById(int id)
        {
            foreach (var product in _products)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }


        // metodo Add
        // aggiunge un nuovo prodotto alla lista dei prodotti
        // 1- Calcola il prossimo ID
        // 2- Aggiunge il prodotto alla lista
        // 3- Ritorna il prodotto aggiunto
        public Product Add(Product newProduct)
        {
            int nextId; // dichiaro una variabile per il prossimo ID
                        // se la lista dei prodotti non è vuota, calcolo il massimo ID esistente
                        // altrimenti imposto il prossimo id a 1
            if (_products.Count > 0)
            {
                int maxId = 0; // imposto il massimo ID a 0
                foreach (var p in _products)
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
            newProduct.Id = nextId; //assegno il prossimo ID al nuovo prodotto

            _products.Add(newProduct); // aggiungo il nuovo prodotto alla lista

            return newProduct; // restituisco il nuovo prodotto aggiunto
        }
        public bool Update(int id, Product updateProduct)
        {
            // Cerco il prodotto manualmente
            Product? existing = null; // dichiaro una variabile per il prodotto esistente
                                      // cicliamo la lista dei prodotti
            foreach (var p in _products)
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
            existing.Name = updateProduct.Name;
            existing.Price = updateProduct.Price;
            return true; // restituisco true se il prodotto è stato aggiornato con successo
        }
    }
}

