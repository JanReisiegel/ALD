# 18. Popište princip MergeSortu a CombSortu

## MergeSort

- Složitost je vždy logaritmická **_O_**(N×log(N))
- Je opakem QuickSortu
- Místo dělení posloupnosti slučování posloupnosti
- Základní myšlenka algoritmu:
  - Setřídit kratší posloupnost zabere méně kroků
  - Spojit dohromady 2 setříděné posloupnosti tak, aby výsledek byl setříděný, je snadnější než když jsou posloupnosti nesetříděné
- Postup
  1. Rozdělí neseřazenou množinu dat na dvě podmnožiny o přibližně stejné velikosti
  2. Rekurzivně (MergeSortem) setřídíme každou vzniklou podmnožinu
  3. Sloučíme 2 podmnožiny

## CombSort

- Je dalším vylepšením BubbleSortu
- Opět řeší problém zajíců a želv
- Zavádí snižující se přírůstek (skok)
- Neporovnávají se tedy sousedi, ale prvkyvzdálené o tento krok
- Při každé iteraci se skok dekrementuje, až je degradován na prostý BubbleSort
- Díky skoku jsou želvy přesunovány rychleji na správnou stranu
- Základem je správná volba skoku
- Empiricky dokázáno, že ideální je výpočet skoku jako postupné dělení pole číslem 4/3
- **[Názorná ukázka](https://www.algoritmy.net/article/51210/Comb-sort)**
