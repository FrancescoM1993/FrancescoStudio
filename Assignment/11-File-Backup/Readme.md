# FILES BACKUP

- Programma che copia i files presenti dentro una cartella in una cartella di backup, mantenendo la struttura delle sottocartelle
- La cartella di destinazione deve avere il nome della cartella d'origine del timestamp nel formato yyyyMMdd_HHmmss

## Funzionalita del Programma

- Tutti i file dalla cartella sorgente.
- Crea una nuova cartella di destinazione con un nome basato sul timestamp corrente (e le subfolders).
- Mantiene i nomi originali dei file durante la copia.
- Se vogliamo possiamo usare le funzioni per gestire le cartelle.

## Struttura originale
```bash
Progetti
├── Progetto1
│   ├── file1.txt
│   ├── file2.txt
├── Progetto2
│   ├── file3.txt
│   ├── file4.txt
```
## Struttura di backup
```bash
Progetti_20231001_123456
├── Progetto1
│   ├── file1.txt
│   ├── file2.txt
├── Progetto2
│   ├── file3.txt
│   ├── file4.txt