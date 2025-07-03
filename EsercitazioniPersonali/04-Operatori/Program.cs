// OPERATORI


/*
i tipi di operatori sono:
    1. Operatori aritmetici
    2. Operatori di confronto
    3. Operatori logici
    4. Operatori di assegnazione
    5. Operatori incremento e decremento
    6. Operatori di concatenazione
*/


// 1. Operatori aritmetici

int a = 11; //int a = 10;
int b = 6; //int b = 5;

int somma = a + b; // somma
//stampo il risultato della somma
Console.WriteLine($"La somma di {a} e {b} è {somma}"); 

int sottrazione = a - b; // sottrazione
//stampo il risultato della sottrazione
Console.WriteLine($"La sottrazione di {a} e {b} è {sottrazione}"); 

int moltiplicazione = a * b; // moltiplicazione
//stampo il risultato della moltiplicazione
Console.WriteLine($"La moltiplicazione di {a} e {b} è {moltiplicazione}"); 

int divisione = a / b; // divisione//int divisione = a / b; // divisione
//stampo il risultato della divisione
Console.WriteLine($"La divisione di {a} e {b} è {divisione}"); 

int resto = a % b; // resto
//stampo il risultato del resto
Console.WriteLine($"Il resto della divisione di {a} e {b} è {resto}");
//modulo 2

int modulo = a % 3; // modulo
//stampo il risultato del modulo
Console.WriteLine($"Il modulo di {a} e 3 è {modulo}");  


// 2. Operatori di confronto (restituendo i valori booleani)

bool uguale = a == b; // uguale
//stampo il risultato dell'uguale
Console.WriteLine($"Il valore di {a} è uguale a {b}: {uguale}"); 

bool diverso = a != b; // diverso
//stampo il risultato del diverso
Console.WriteLine($"Il valore di {a} è diverso da {b}: {diverso}");

bool maggiore = a > b; // maggiore
//stampo il risultato del maggiore
Console.WriteLine($"Il valore di {a} è maggiore di {b}: {maggiore}");

bool minore = a < b; // minore
//stampo il risultato del minore
Console.WriteLine($"Il valore di {a} è minore di {b}: {minore}");

bool maggioreUguale = a >= b; // maggiore uguale
//stampo il risultato del maggiore uguale
Console.WriteLine($"Il valore di {a} è maggiore o uguale a {b}: {maggioreUguale}");

bool minoreUguale = a <= b; // minore uguale
//stampo il risultato del minore uguale
Console.WriteLine($"Il valore di {a} è minore o uguale a {b}: {minoreUguale}");


// 3. Operatori logici (or, and, not)

bool condizione1 = true;
bool condizione2 = false;

/*
tabella
a   b   and   or not'a' 'b'
0   0   0     0      1   1
0   1   0     1      1   0
1   0   0     1      0   1
1   1   1     1      0   0
Logica booleana che si usa negli if dove ho 1 il bool praticamente è vera la condizione e quindi entra dentro
*/

bool and = condizione1 && condizione2; // and (&&) significa che entrambe le condizioni devono essere vere
//stampo il risultato 
Console.WriteLine($"Il risultato dell'operatore and tra {condizione1} e {condizione2} è {and}");

bool or = condizione1 || condizione2; // or (||) significa che almeno una delle condizioni deve essere vera
//stampo il risultato
Console.WriteLine($"Il risultato dell'operatore or tra {condizione1} e {condizione2} è {or}");

bool not = !condizione1; // not (!) significa che restituisce il valore opposto della condizione
//stampo il risultato
Console.WriteLine($"Il risultato dell'operatore not tra {condizione1} è {not}"); //(il not inverte il valore della condizione)

// 4. Operatori di assegnazione

int c = 10; 
c += 5; //somma e assegna 
//stampo il risultato
Console.WriteLine($"Il valore di c dopo l'assegnazione è {c}"); 

c -= 5; // sottrae e assegna    
//stampo il risultato
Console.WriteLine($"Il valore di c dopo l'assegnazione è {c}"); 

c *= 5; // moltiplica e assegna
//stampo il risultato
Console.WriteLine($"Il valore di c dopo l'assegnazione è {c}"); 

c /= 5; // divide e assegna
//stampo il risultato
Console.WriteLine($"Il valore di c dopo l'assegnazione è {c}");


// 5. Operatori incremento e decremento

c = c + 1;
c++; // incremento di 1 unita
//stampo il risultato
Console.WriteLine($"Il valore di c dopo l'incremento è {c}"); // 11

c = c + 2;
c += 2; // incremento di 2 unita
//stampo il risultato
Console.WriteLine($"Il valore di c dopo l'incremento è {c}"); // 12

c--; // decremento di 1 unita
//stampo il risultato
Console.WriteLine($"Il valore di c dopo il decremento è {c}"); // 9

// 6. Operatori di concatenazione

//metodo 1 quello vecchio

string nome = "Nome di persona";
string cognome = "Cognome di persona";
string nomeCompleto = nome + " " + cognome; // concatenazione
//stampo il risultato
Console.WriteLine($"Il nome completo è {nomeCompleto}"); 

//metodo 2 concatenazione con string interpolazione

string nomeCompleto2 = $"{nome} {cognome}";    
//stampo il risultato
Console.WriteLine($"Il nome completo è {nomeCompleto2}");
