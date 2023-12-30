# 20. Vyhledávání, oč jde, zákl. pojmy, rozdíl mezi lieárním a binárním vyhledáváním

## Základní pojmy

- Vyhledávání = Search
- Elementární popis - hledáme klíč _k_ v množině **S**.
- Klíč = Query = Dotaz
- Množina klíčů S = prohledávaný prostor = search space
  - Statický
    - Velikost v čase je konstantní
    - Snadno se implementuje
    - Změna vy\tvoří novou verzi prostoru
    - Příklady: telefonní seznam, slovník, některé ADT
  - Dynamický
    - Velikost v čase se mění
    - Implementace operací je náročnější
    - Příklady: ADT jako slovník, seznam a další
- Typ prohledávaného prostoru určuje jaký algoritmus zvolíme i jak ho musíme implementovat

## Lineární vyhledávání

- Jednoduchý a často používaný způsob
- Postupně procházíme všechny prvky **S** dokud nenajdeme _k_
- Lineární složitost **_O_**(N)
- pracuje na obecné množině (neseřazené)

## Binární vyhledávání

- Metoda půlení intervalu
- **S** musí být uspořádaný
- Rekurzivní algoritmus D&C
- Logaritmická složitost **_O_**(log(N))

## Porovnání Binárního a Lineárního Vyhledávání

- Pokud vyhledávám menší počet v neseřazených datech, vyplatí se **Lineární vyhledávání**
- Pokud hledám opakovaně _x_ různých hodnot
  - pokud x < log2(N) stále se vyplatí lineárně
  - pokud x > log2(N) vyplatí se setřídit a vyhledat binárně
  - N = 20000, log2(N) = 14,29 (binární)

|  _x_ | lineárně | binárně + HeapSort |
| ---: | :------: | :----------------: |
|    1 |  20000   |       285754       |
|   10 |  200000  |       285897       |
|   20 |  400000  |       286040       |
|  100 | 2000000  |       287183       |
| 1000 | 20000000 |       300042       |
