# 17. Popište princip InsertSortu a QuickSortu

## InsertSort

- Pracuje na principu vkládání na správné místo
- Využívá k tomu pomocný prvek, zpravidla nultý prvek posloupnosti
  1. První prvek pole je ponechán na svém místě
  2. Vezmeme druhý prvelk pole a porovnáme jej s prvním
     - Je-li menší, zařadíme ho na první místo a první prvek posuneme
     - V opačném případě ponecháme na místě
  3. Vezmeme třetí prvek a porovnáme jes s prvními dvěma prvky
     - Je-li menší než některý znich, zařadíme jej na odpovídající pozici a následující prvky podle potřeby přesuneme
     - Jinak je ponecháme na původních místech
  4. Obdobně postupujeme i s ostatními prvky

## QuickSort

- Pracuje na principu rozdělení pole řazených prvků na dvě části a ty potom seřadí
- Využívá rekurzi
  1. Zvolit prvek - pivota. Tento je umístěn na konečné pozici
  2. Projdeme pole zleva dokud nenalezneme větší prvek
  3. Dále ho projdeme zprava, dokud nenalezneme menší prvek než dělící prvek
  4. Tyto prvky pak vyměníme
  5. Kroky 2. - 4. opakujeme až do kompletního setřídění
- [QuickSort Pro ilustraci](https://www.youtube.com/watch?v=ywWBy6J5gz8)
