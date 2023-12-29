# 16. Popište princip SelectSortu a BubbleSortu
## SelectSort
* Velmi jednoduchý
* Složitost je ***O***(N^2)
* SelectSort je vnitřní, nestabilní
* Princip - nalezne minimální prvek v nesetříděné části a zařadí ho na konec setříděné posloupnosti
    1. V posloupnosti najdeme nejmenší prvek a vyměníme ho s prvkem na
první pozici
        - Rozdělení posloupnosti na dvě části.
        - Setříděná část obsahuje pouze jeden prvek, nesetříděná n 1.
    2. V nesetříděné části najdeme nejmenší prvek
        - Vyměníme ho s prvním prvkem v nesetříděné části
        - Dojde k zařazení tohoto prvku do setříděné části.
    3. Obsahuje li nesetříděná část více než jeden prvek, pokračujeme
bodem 2, jinak je třídění ukončeno.

## BubbleSort
* Porovnává vždy dvojice
* Pokud menší číslo následuje po větším - výměna
* Maximální prvek "probublá" na konec
