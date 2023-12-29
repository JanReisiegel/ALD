# 4. Kritéria pro rozčlenění ADT, typ ukazatel

## Kritéria pro rozdělení ADT

- Počet a Vzájemné uspořádání složek
  - sttické = neměnné
  - dynamické = měnící se
- Typ objektů uvnitř
  - homogenní = všechny stejného druhu
  - nehomogenní = různého typu
- Existuje bezprostřední následník
  - lineární = neexistuje (např.: pole, seznam, ...)
  - nelineární = existuje (např.: strom, tabulka, ...)

## Ukazatel - Pointer

- základ dynamických datových struktur v některých jazycích (C)
- Nedeklaruje se v deklarační části programu, ale přímo v těle programu
- Uchovává adresu prvku v operační paměti
- Adresa, na ktreou ukazuje, může být v libovolné části operační paměti
- Konkrétní typ ukazatele je určen dle datového typu dynamické proměnné, na kterou ukazuje
- Každý ukazatel slouží jedné dynamické proměnné

Code in C:

```
// promenna typu int
int pocet = 23;
// pointer na misto v pameti pro hodnotu int
int *p;
// do p ulozena adresa pameti kde je pocet
p = &pocet;
// zmena hodnoty na adrese i v pocet
p = 56;
```
