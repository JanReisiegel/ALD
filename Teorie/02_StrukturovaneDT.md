# Strukturované datové typy

V podtsatě se jedná o skupinu jednodušších typů. Každý strukturovaný datový typ poskytuje prostředky pro práci s prvky dat.

1. Pole (Array)
2. Řetězec (String)
3. Abstrakrní datové typy (ADT)
   - Ukazatel (Pointer)
   - Zásobník (Stack)
   - Fronta (Queue)
   - Tabulka (Table, Map)
   - Seznam (List)
   - Strom (Tree)
   - Množina (Set)

## Pole (Array)

- Skládá se z **pevného počtu** položek **stejného typu**
- Položky se rozlišují pomocí indexu
- Mezi položkami dat a hodnotami indexů existuje _jednoznačné přiřazení_
- Při definice se určuje jeho rozměr a datový typ (rozměr určuje počet prvků)
- index pole je většinou typu **integer**, může jím však být i jiný **ordinální** datový typ
- Pole lze definovat dynamicky
  _ pomocí ukazatelů (C, Pascal)
  _ některé jazyky podporují přímo (PHP, Python)
  Pole indexované **řetězci** = ADT tabulka či mapa

## Řetězce (String)

- pole znaků (char array)
- OOP jazyky implementují String jako datový typ (Java, C#)
- Přístup k řetězci:
  - Analogicky jako k poli
  - Pomocí ukazatelů (C)
  - Objektový datový typ String
