# Datové typy a jejich rozdělení

1. Jednoduché datové typy
2. Strukturované datové typy

## Jednoduché datové typy

Jsou definovány identifikátorem a datovým typem v deklarační oblasti. V paměťovém prostoru je uložena přímo hodnota této proměnné/konstanty.

- Ordinální
- Neordinální

### Ordinální datové typy

- Hodnota má svého předchůdce nebo/a následovníka
- Její pozi lze číselně ohodnotit - ordinální číslo
- ASCII tabulka

Základní ordinální typy:

- Integer
- Boolean
- Char
- Interval
  - Souvislá neprázdná množina hodnot
  - Horní a dolní mez dána konstantou daného ordinálního typu
- Enum
  - Datový typ definovaný uživatelem
  - Jednotlivé hodnoty mají svá ordinální čísla
    - enum {pondeli, utery, streda, ctvrtek} dny;
    - ord(pondeli)=0, odr(utery)=1, ...

### Neordinální datové typy

Především datový typ real:

- konečná podmnožina hodnot reálného typu
- Hodnoty s pohyblivou desetinnou čárkou
- V paměti uložen jako dvojice hodnot (M,N)
  - M - mantisa
  - N - exponent
- Má omezení => pouze tzv. **strojová nula**
  - určena intervalem: (o, minreal)
    - minreal - absolutní hodnota minimálně zobrazitelné hodnoty na daném HW
- Možno provádět konverze integer => real nebo real => integer - provází ztráta přesnosti

## Strukturované datové typy

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
