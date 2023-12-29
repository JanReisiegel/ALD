# 7. Popište ADT Seznam, rozdíl oproti LIFO (resp. FIFO)

## Seznam (List)

- zobecnění fronty a zásobníku
- Data lze přidávat a odebírat na libovolné místo seznamu
- Počet a vzájemné uspořádání se mění => dynamické
- Typ objektů je stejný => homogenní
- Neexistuje bezprostřední následník => lineární
- V seznamu je ukazovátko, které označuje místo v seznamu
- Kam ukazovátku ukazuje tam můžeme vkládat, číst, přepisovat, nebo mazat

### Linked List (Lineární seznam)

- nejčatější forma implementace
- Typy:
  - Jednosměrný
    - prvek odkazuje pouze na následující prvek
  - Dopředný
    - prvek ukazuje puze na předchozí prvek
  - Obousměrný
    - prvek ukazuje na následující i předchozí prvek
  - Kruhový
    - Libovolný (jednosměrný, dopředný nebo obousměrný)
    - Navíc poslední prvek ukazuje na první (podle pravidel typu viz výše)
- Operace:
  - Vytvoření seznamu
  - Vložení prvku
  - Odebrání prvku
  - Test prázdnosti
  - Vyhledávání
  - Počet prvků
  - Vymazání celého
  - posun vpřed či vzad

## Lineární seznam vs. LIFO (FIFO)

- V seznamu lze přistupovat k jakémukoli prvku (číst, upravovat, vkládat)
- Seznam umožňuje vyhledávání
