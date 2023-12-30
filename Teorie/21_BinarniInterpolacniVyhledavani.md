# 21. Binární a interpolační vyhledávání

## Interpolační vyhledávání

- Varianta binárního
- Sbaha simulovat lidské chování, např. vyhledávání ve slovníku
- Na rozdíl o dbinárního vyhledávání nepočítáme medián, ale odhad dle vzorce:

```
                   (last - first)
aprox = first + -------------------- × (k - a[first])
                 a[last] - a[first]
```

## Binární vyhledávání

- Metoda půlení intervalu
- **S** musí být uspořádaný
- Rekurzivní algoritmus D&C
- Logaritmická složitost **_O_**(log(N))
- Při vyhledávání se vypočítá medián
- Příklad:
  - Pole a - 50 prvků -> [0 2 4 6 8 10 ... 94 96 98]
  - hledáme **_k_ = 8**, left = 1, right = 49
  - medián = (49+1)/2 = 25
  - a[25] > 8 takže se nám změní right = 25
  - Postup opakujeme dokud a[medián] != _k_
  - Při výpočtu tohoto příkladu by interpolační metoda vypadala:
    - aprox = 1+[(49-1)/(96-2)]×(8-2) = 4
    - a[4] = 8 => **HOTOVO**
