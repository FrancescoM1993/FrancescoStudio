## Versione 2

- In questa versione l obbiettivo è implementare un servizio che prenda
da un file json invece che da un elenco o lista interna

(Attualmente i dati vengono presi da ProductService tramite una lista interna)

- Il file json che contiene i dati è organizzato come una lista di oggetti ("simili a dizionari")

- il file json verrà deserializzato usando una classe Album con le seguenti proprietà

- Id (int,generato autonomamente)
- Titolo (string)
- Anno (int)
- Autore (string)
- Canzoni [<'list'>] 
- Genere 
- Ascoltato (bool)

- In questa versione non è necessario una versione dell'input dell'utente dato che lo scopo è di servire i dati al frontend tramite un servizio http

- L applicazione deve essere in grado di generare un id progressivo (ultimoid ++)

# CONTROLLER

- Il servizio dovrà implementare i seguenti endpoint:
- GET/albums: restituisce l' elenco di tutti gli album
- GET/albums: restituisce un album specifico
- POST/albums:
- PUT/albums: aggiorna un albul esistente
- DELETE/albums: eliminare un album esistente

# CURL

- Devono essere implementati i comandi principali per testare
- GET/: per ottenere l' elenco degli album
- POST/: per aggiungere un album
- PUT/: aggiorna un album 
- DELETE/: eliminare un album 

# ESEMPIO DI COMANDO CURL

- Esempio di comando per aggiungere album:

curl -X POST http://localhost:5017/api/album \
-H "Content-Type: application/json" \
-d '{
    "titolo" : "Album",
    "anno" : 2021,
    "autore" : "Artista",
    "canzoni" : [{"titolo": "durarra","Durata":"sgsgfds","Artista":"sdghfdh"}],
    "genere" : "Pop",
    "ascoltato" : false
}'

curl -X DELETE http://localhost:5017/api/album/1 \
-H "Content-Type: application/json"
- Esempio di comando per eliminare un album:
