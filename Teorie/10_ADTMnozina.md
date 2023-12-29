# 10. ADT Množina - co o něm víte

## Množina (Set)

- Nemá garanci pořadí prvků
- Garance jedinečnosti prvku
- Princip
  - Implementace založena na seznamu
  - Bez reference na aktuální prvek
  - Implementace musí hlídat unikátnost
  - Přímočará, ale neefektivní Při hledání prvku je třeba projít celou množinu - O(n)
- Lepší použít hashovací tabulku
