# 22. Binární vyhledávací stromy (BVS) - vlastnosti, metody procházení, vkládání a odstranění prvku

- Binary search tree BST
- Další z využití binárních stromů
- Vlastnosti:
  - Hodnota klíče uzlu **x = v(x)**
  - Pro všechny uzly levého podstromu **y~L~** platí, že **v(y~L~) < v(x)**
  - Pro všechny uzly pravěho podstromu **z~R~** platí, že **v(z~R~) > v(x)**
- Využití:
  - Hledání určitého klíče
  - Hledání minima a maxima
  - Řazení dat
    - inorder BVS zobrazí seřazenou množinu
    - pomalejší než HeapSort (QuickSort, MergeSort)
    - efektivní metoda online řazení
- Implementace
  - Stejně jako klasický strom
  - Rozdíl je pouze v metodách pro vkládání a mazání uzlů
  - Nově metoda pro hledání

## Vkládání uzlu

Nejprve najdeme rodiče, poté připojíme jako nový uzel

## Odstranění uzlu

- Postup odstranění záleží na počtu potomků konkrétního uzlu:
  1. Uzel nemá potomky (list) => můžeme ho odstranit
  2. Uzel má jednoho potomka => nahradíme uzel potomkem, odstraníme potomka
  3. Uzel má 2 potomky
     1. Označme takový uzel jako N
     2. Hodnotu uzlu N nahradíme nejbližší vyšší, nebo nižší hodnotou
     3. Takový uzel má nanejvýš jednoho potomka
