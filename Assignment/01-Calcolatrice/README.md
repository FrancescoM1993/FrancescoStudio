# CALCOLATRICE

## Descrizione

Scrivere un programma che simuli una calcolatrice. Il programma deve essere in grado di eseguire le seguenti operazioni

- Somma
- Sottrazione
- Moltiplicazione
- Divisione

## Requisiti

- Il programma deve chiedere all'utente di inserire due numeri e l' operazione da eseguire.Il programma deve quindi eseguire l'operazione e stampare il risultato.

- Il programmma deve gestire la divisione per zero e stampare un messaggio di errore in casi di divisione per zero.

## Suggerimenti

- Il programma chiede all'utente una cosa alla volta tipo prima chiede il primo numero poi il secondo numero poi l'operazione da eseguire.

- In modo da gestire correttamente l'errore di divisione per zero,il programma deve controllare se il secondo numero è zero prima di eseguire l'operazione di divisione.

>In pratica devo usare un if per controllare se il secondo numero è zero prima di eseguire l'operazione di divisione.

- Il programma deve essere in grado di gestire solo interi senza numeri decimali.

- Il programma deve essere in grado di gestire solo le operazioni di somma,sottrazione,moltiplicazione e divisione. Se l'utente inserisce un'operazione non valida, il programma deve stampare un messaggio di errore.

- Posso creare l'archetipo dotnet con il comando `dotnet new console` e poi copiare il codice in questo file.

## Codice

```csharp
//Calcolatrice

// chiedo all'utente di inserire il primo numero

// chiedo all'utente di inserire il secondo numero

// chiedo all'utente di inserire l'operazione da eseguire

// se l operazione scelta dall utente è divisione
// se il secondo numero è uguale a 0

// stampo un messaggio di errore

// altrimenti eseguo l'operazione scelta dall'utente

// stampo il risultato dell'operazione


# CALCOLATRICE (versione 2)

## Suggerimenti
- Usare un ciclo while per continuare a chiedere all utente di inserire i numeri e l operazione fino a quando non decide di uscire.
- Usare un istruzione `break` per uscire dal ciclo quando l utente risponde no.

## Esempio di codice (solo commenti)

// Calcolatrice
// chiedo all'utente di inserire il primo numero
// chiedo all'utente di inserire il secondo numero
// chiedo all'utente di inserire l'operazione da eseguire
// verifico se l'operazione è valida
// se l operazione scelta dall utente è divisione
// se il secondo numero è uguale a 0
// stampo un messaggio di errore
// altrimenti eseguo l'operazione scelta dall'utente
// stampo il risultato dell'operazione
// chiedo all'utente se vuole continuare
// se l'utente risponde si
// altrimenti esco dal ciclo

## Esempio di codice 
```csharp
