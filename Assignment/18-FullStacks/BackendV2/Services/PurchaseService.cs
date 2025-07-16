using Backend.Models;
namespace Backend.Services
{

    public class PurchaseService
    {
        // Inizializziamo una lista di prodotto in memoria
        private readonly List<Purchase> _purchases = new();
        

        // Restituisce tutti i prodotti
        //public List<Purchase> GetAll() => _purchases;

        //Ciclo in modo esplicito per restituire i prodotti

        public List<Purchase> GetAll()
        {
            List<Purchase> result = new List<Purchase>();
            foreach (var purchase in _purchases)
            {
                result.Add(purchase);
            }
            return result;
        }


        //public Purchase? GetById(int id) => _purchases.FirstOrDefault(p => p.Id == id);

        public Purchase? GetById(int id)
        {
            foreach (var purchase in _purchases)
            {
                if (purchase.Id == id)
                {
                    return purchase;
                }
            }
            return null;
        }


        // metodo Add
        // aggiunge un nuovo prodotto alla lista dei prodotti
        // 1- Calcola il prossimo ID
        // 2- Aggiunge il prodotto alla lista
        // 3- Ritorna il prodotto aggiunto
        public Purchase Add(Purchase newPurchase)
        {
            int nextId; // dichiaro una variabile per il prossimo ID
                        // se la lista dei prodotti non è vuota, calcolo il massimo ID esistente
                        // altrimenti imposto il prossimo id a 1
            if (_purchases.Count > 0)
            {
                int maxId = 0; // imposto il massimo ID a 0
                foreach (var p in _purchases)
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
            newPurchase.Id = nextId; //assegno il prossimo ID al nuovo prodotto

            _purchases.Add(newPurchase); // aggiungo il nuovo prodotto alla lista

            return newPurchase; // restituisco il nuovo prodotto aggiunto
        }
        public bool Update(int id, Purchase updatePurchase)
        {
            // Cerco il prodotto manualmente
            Purchase? existing = null; // dichiaro una variabile per il prodotto esistente
                                      // cicliamo la lista dei prodotti
            foreach (var p in _purchases)
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
            existing.UserId = updatePurchase.UserId;
            existing.ProductId = updatePurchase.ProductId;
            existing.Quantity = updatePurchase.Quantity;
            existing.PurchaseDate = updatePurchase.PurchaseDate;
            return true; // restituisco true se il prodotto è stato aggiornato con successo
        }
    }
}

