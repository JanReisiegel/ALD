# 23. Vyvažování stromů - co to je, proč to je, co je bal a rotace

## Vyvážený strom

- Má vyhledávání se složitostí **_O_**(log(N))
- Známe několik typů. Rozdíl mezi nimi určujeme podle toho, jak je vyvážen
  - Vyvážen podle výšky podstromů - AVL strom - samovyvažovací strom (hloubka levého a pravého podstromu se liší nejvýše o 1)
  - Vyvážen podle výšky + počtu potomků
  - Vyvážen podle váhy podstromů (počty uzlů) - váhově vyvážený strom

## bal

- faktor vyvýženosti uzlu **u**

```
balu(u) = h~L~ - h~R~
```

- h~L~ je výška levého podstromu a h~R~ je výška pravého podstromu
- Výška prázdného podstromu je -1
- Výška neprázdného podstromu je max(h~L~,h~R~)
- Pro všechny uzly u BVS AVL musí platit že bal(u) = {-1,0,1}
- Pokud má uzel jinou hodnotu faktoru vyváženosti je strom nevyvážený => musí se vyvážit

## Rotace

Pokud je strom nevyvážený (existuje uzel který má bal(u) mimo množinu {-1, 0, 1}), musí se strom vyvážit. Vyvažování se provádí tzv. rotacemi. Známe 4 druhy rotací:

- L rotace
  - Uzel A má pravého potomka B a nalevo podstrom x
  - uzel B má levý podstrom y a pravý podstrom z, který má vyšší hloubku než y o 1 (podstromy x a y mají stejnou výšku)
  - uzel B nahradí uzel A, A je nyní levým potomkem B, podstrom y se stane pravým podstromem A,
- R rotace
  - Uzel B ma levého potomka A a pravý podstrom z
  - Uzel A má pravý podstrom x a levý podstrom y, x je vyšší než y (y = z)
  - Uzel A se prohodí s uzlem B tak, že B je pravým potomkem A, y se stane levým podstromem B
  - Strom je vyvážený
- LR rotace
  - Nejdříve se provede levá rotace a poté pravá rotace
- RL rotace
  - nejdříve se provede pravá rotace a poté levá rotace

Rotace se provádí při vkládání prvku

### Insert do AVL stromu

1. Otestujeme, zda se daný uzel ve stromu již nenachází
2. Pokud ne, přidáme nový (jako BST) a určíme jeho bal
3. Následně musíme zkontrolovat bal všech jeho předků
4. Došlo-li k rozvážení stromu (bal = {-2,2}), musíme vyvažovat pomocí vhodné rotace

Rotace se určuje podle bal: (P je kořen, L je levý potomek a R je pravý potomek)

- bal(P) = 2 => levý podstrom převažuje pravý
  - bal(L) = 1 použijeme pravou rotaci
  - bal(L) = -1 použijeme LR rotaci
- bal(P) = -2 => pravý podstrom převažuje levý
  - bal(P) = 1 použijeme RL rotaci
  - bal(P) = -1 použijeme levou rotaci

### Odtsranění uzlu

Postupujeme stejně jako u BVS, ale navíc musíme vyvážit strom.
