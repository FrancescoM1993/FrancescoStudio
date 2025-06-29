# CATALOGO PRODOTTI

Programma che permetti di gestire un catalogo di prodotti.

## Descrizione

Il programma consente di gestire un catalogo di prodottu,permettendo di aggiungere e visualizzare i prodotti.

I prodotti sono memorizzati in un dizionario,dove la chiave è un identificatore univoco del prodotto e il valore è un oggetto che rappresenta il prodotto stesso.

Il dizionario ha unca chiave numerica ed una lista du oridittu come valore.Ogni prodotto ha un `nome`,un prezzo e una descizione.

# Funzionalità

Il programma deve chiedere all'utente di inserire un numero per scegliere una delle seguenti opzioni:
1. Aggiungi un prodotto
2. Rimuovi un prodotto
3. Visualizza tutti i prodotti
4. Esci

Il programma deve chiedere all'utente di inserire i dati del prodotto(nome,prezzo,descrizione)quando si sceglie di aggiungere un prodotto.Il prezzo deve essere un numero decimale e la descrizione non può essere una stringa vuota.

# Suggerimenti
- Utilizza un dizionario per memorizzare i prodotti,dove la chiave è un identificatore univoco(ad esempio un numero intero) e il valore è un oggetto che rappresente il prodotto.
- Utilizza i metodi `add`,`remove` e `tryGetValure` del dizionario per gestire i prodotti.
- Utilizza i metodi di conversione per convertire le stringe in numeri decimali e viceversa.
- Utilizza le condizioni per verificare se il prezzo è un numero decimale valido e se la descrizione non è vuota

# Codice (solo commenti)

// dichiaro un dizionario per memorizzare i prodotti

// dichiaro una variabile per tenere traccia dell'ID del prodotto

// ciclo per gestire le opzione del menu

// chiedo all'utente di inserire un numero per scegliere un'opzione

// gestisco L'opzione 1: Aggiungi un prodotto

// chiedo all'utente di inserire il nome del prodotto

// chiedo all'utente di inserire il prezzo del prodotto

// verifico se il prezzo è un numero decimale valido

// chiedo all'utente di inserire la descrizione del prodotto

// verifico se la descrizione non è vuota

// creo un oggetto prodotto con i dati inseriti

// aggiungo il prodotto al dizionario con l'ID come chiave

// incremento l'ID del prodotto

// gestisco l'opzione 2: Rimuovi un prodotto

// chiedo all'utente di inserire l'ID del prodotto da rimuovere

// verifico se l'ID esiste nel dizionario

// rimuovo il prodotto dal dizionario

// gestisco l'opzione 3: Visualizza tutti i prodotti

// ciclo per visualizzare tutti i prodotti nel dizionario

// gestisco l'opzione 4: Esci

// esco dal ciclo e termino il programma