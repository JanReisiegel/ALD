# 9. Popište ADT Dynamické pole, srovnání, princip, výhody atd.

- Datový kontejner postavený nad polem
- Eliminuje základní nedostatek pole => **_fixní velikost_**
- Poskytuje zíkladní sadu funkcí:
  - Přidání prvku do pole - add(x) - x = hodnota vkládaná do pole
  - Odstranění prvku z pole - revome(i) - i = index prvku v poli
  - Získání prvku z pole - get(i) - i = index prvku v poli
  - Zjištění počtu prvků v poli - size()
- Princip:
  - Prvky jsou ukládány ve vnitřním poli s fixní délkou
  - Jakmile je vyčerpána kapacita tohoto pole:
    - Vytvoří se nové větší pole (cca 2× kvůli amortizaci)
    - Stávající prvky se překopírují
    - Staré pole se realokuje
  - Analogický postup při velké neobsazenosti
  - Složitost se pohybuje od O(1) do O(n)
