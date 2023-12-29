# 6. Popište Kruhový buffer - princip, vlastnosti,možnost použití atd.

- Speciální příklad FIFO
- Používaný jako vyrovnávací paměť
- Princip:
  - Tvořený fixním polem a 2 ukazateli na první obsazený a poslední volný prvek (first / last)
  - Při přidání prvku se **last** inkrementuje v kruhu
  - Při odebrání se inkrementuje first, původní se přemaže (uvolní)
  - Vše je implementováno v kruhu
- Složitost čtení (odstranění) je O(1)
