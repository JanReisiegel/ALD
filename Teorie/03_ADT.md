# Abstraktní datové typy - ADT

Ekvivalentní pojmy:

- Abstraktní datové struktury
- Dynamické datové struktury

Struktury, jejichž _rozsah_ se během programu může **měnit**. Používají se tehdy, když nám základní datové typy **přestávají stačit**. Některé se neustále opakují. Obvykle jsou implementovány v **knihovnách** nebo přímo v **jazyce**. Všechny ADT lze označit za **kontejnery**.

Hlavní výhoda ADT:

- Snadné používání pomocí metod či funkcí
- vlastní implementace je programátorovi skryta

## ADT - kontejner

ADT určený k organizovanému skladování jiných objektů podle určitých pravidel. Každý kontejner by měl mít definované operace:

- Vytvoření prázdného kontejneru (koncstruktor, init)
- Zjištění počtu uložených objektů (size)
- Přístup k prvkům (read, top, front, ...)
- Vložení objektu (insert, push, ...)
- Odstranění objektu (delete, pop, ...)
- Vymazání všech uložených objektů (clear)

Mezi známé zástupce například patří:

- Zásobník
- Fronta
- Seznam
- ...
