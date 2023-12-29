# 8. Popište ADT Heap - princip, vlastnosti,možnost použití

## Heap - Halda

- Halda je strom splňující vlastnosti haldy
  - Vlastnost Haldy: B je potomek A =>
    - h(A) >= h(B) max-heap
    - h(a) <= h(B) min-heap
  - Funkce h(X) udává hodnotu uzlu X
- Chová se jako prioritní fronta
- Na vrcholu je vždy prvek s nejvyšší prioritou podle typu haldy (max-heap / min-heap)
- Typ stromu určuje zároveň typ haldy
  - např.: **binární** haldy
- Strom typu halda musí být vyvážený nebo se poslední úroveˇn stromu zaplňuje zleva doprava

### Binární halda

- binární strom
- Konstrukce
  1. Přídáme nový uzel na spodní úroveň haldy
  2. Porovnáme přidaný uzel s rodičem
     - Pokud je ve správném vztahu (min-heap / max-heap) končíme
     - Pokud není ve správném vztahu, prohodíme uzel s rodičem a opakujeme předešlý krok
- Maximální počet kroků je roven výšce stromu => složitost O(log n)
- Obecně platí:
  - cca 50% uzlů = listy
  - cca 75% uzlů se nachází v posledních 2 úrovních
- Většina přesunů se uskuteční jen o pár úrovní
- Binární halda umožňuje vkládání v rychlejší čase, než je dán složitostí
