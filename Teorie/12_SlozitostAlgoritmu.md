# 12. Co víte o složitosti algoritmu ?

Každému algoritmu lze jednoznačně přiřadit **rostoucí funkci** zvanou **asymptotická složitost**, která charakterizuje počet operací algritmuv závislosti na rostoucím rozsahu vstupních dat.

## Jak počítat složitost?

- Sečíst _všechny_ elementární operace
  - Porovnání dvou čísel
  - Aritmetická operace
  - Přesun čísla v paměti
- Zjednodušení 1: počítáme **pouze** elementární operace nad daty
- Zjednodušení 2: počítáme **pouze porovnání čísel** nad daty

## Asymptotická složitost algoritmu

Asymptotická složitost algoritmu **A** je řád růstu funkce f(N), která charakterizuje počet elementárních operací algoritmu **A** při zpracování dat o rozsahu **N**.

_Obvykle místo asymptotická složitost algoritmu říkáme pouze složitost algoritmu_

## Řád funkce

- Řád růstu funkce _f_ je "co nejjednodušší" funkce _g_, taková že _f_ je asymptoticky ohraničena funkcí _g_ z obou stran
- Řád funkce určíme tak, že zanedbáme:
  - Aditivní členy rostoucí pomaleji, nebo stejně rychle
  - Multiplikativní konstantu

Příklad

```
f(n) = 7×2^n + 2×2^n-1 + 4× 3^n-2   řád f(n) je 2^n
ff(n) = n + log2(n)                  řád ff(n) je n
```

## Zápis složitosti

Složitost algoritmu zapisujeme pomocí "**velké _O_ anotace**" jako **_O_**(f(n)) (např.: **_O_**(N))

## Složitost některých algoritmů:

- **_O_**(1) indexování prvku v poli
- **_O_**(log2(N)) vyhledávání prvku v seřazeném poli metodou půlení intervalu
- **_O_**(N) vyhledávání prvku v neseřazeném poli lineárním vyhledáváním
- **_O_**(N×log(N)) seřazení pole reálných čísel podle velikosti (např.: MergeSortem)
- **_O_**(N^2) diskrétní Fourierova transformace (DFT)
- **_O_**(2^N) přesné řešení problému obchodního cestujícího

## Názvy složitostí, dle řádu funkce

- **_O_**(1) - konstantní
- **_O_**(log(N)) - logaritmická
- **_O_**(N) - lineární
- **_O_**(N×log(N)) - lineárně-logaritmická
- **_O_**(N^2) - kvadratická
- **_O_**(N^3) - kubická
- obecně **_O_**(N^X) - polynomiální
- obecně **_O_**(X^N) - exponenciální
- **_O_**(N!) - faktoriálová
