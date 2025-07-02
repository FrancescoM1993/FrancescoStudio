## JSON MANAGER

Il programma deve permettere di gestire una serie di files json dentro ad una folder specifica

### Il programma deve permettere di:
- Aggiungere un nuovo file json
- Modificare alcuni campi come disponibile e quantita di un file json
- Eliminare un file json
- Visualizzare un elenco dei files json presenti nella cartella
- Visualizzare il contenuto di un file json specifico
- Visualizzare i prodotti disponibili per categoria
- Visualizzare i prodotti disponibili per magazzino

### Requisiti:
- Il programma deve chiedere all utente di scegliere un'azione tra quelle disponibili (quindi deve esserci un menu della azioni disponibili)
- Il programma deve essere organizzato in funzioni
- Il programma deve deserializzare i dati in oggeti json
- Gli oggetti devono essere rappresentati da classi con le proprieta accessibili tramite `get` e `set`
- Il programma deve usare i metodi di files in modo da poter leggere e scrivere i files json 
- Ogni files json deve avere come nome l'id univoco del prodotto
- Una funzione deve essere dedicata alla gestione di un id univoco per il file json
- Il programma deve essere in grado di gestire eventuali errori (ad esempio file non trovati, formati errati, ecc.)
- Il programma deve essere in grado di visualizzare i prodotti disponibili divisi per categorie e per magazzino
- Deve essere presente un file Readme con la descrizione di cosa fa ogni funzione e di come lo fa

### Esempio di file json:
```json
prodotti/1.json
{
    "codice": "1",
    "nome": "Prodotto Esempio",
    "disponibile": true,
    "quantita": 100,
    "categorie": ["Elettronica", "Computer"],
    "posizione": {
        "magazzino": "magazzino-1",
        "scaffale": 20
    }
}
