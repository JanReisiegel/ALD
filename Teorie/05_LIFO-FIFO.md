# 5. Popište LIFO, FIFO - vše o co nich víte

## LIFO - Zásobník (Stack)

- LIFO - Last-In-First-Out
- Všechny prvky jsou stejného typu => homogenní
- Neexistuje bezprostřední následek => lieární
- Počet a vzájemné uspořádání se mění => dynamické
- Lze přistupovat pouze k vrcholu => vkládání pouze na vrchol
- Lze implementovat pomocí pole nebo lineárního seznamu
- Využití:
  - Odložení informace
  - Výběr v opačném pořadí
- Operace
  - Vytvoření prázdného zásobníku (create)
  - Přidání prvku na vrchol Zásobníku (push)
  - Odebrání prvku z vrcholu zásobníku (pop)
  - Testování prázdnosti zásobníku (top, is_empty)

## FIFO - Fronta (Queue)

- FIFO - First-In-First-Out
- Všechny prvky jsou stejného typu => homogenní
- Neexistuje bezprostřední následek => lieární
- Počet a vzájemné uspořádání se mění => dynamické
- Prvky se odebírají ve stejném pořadí v jakém byly vloženy
- Lze implementovat setejně jako zásobník
- Operace
  - Vytvoření prázdného fronty (create)
  - Přidání prvku na konec fronty (push)
  - Odebrání prvku ze začátku fronty (pop)
  - Testování prázdnosti fronty (is_empty)
