# 19. Popište princip ShellSortu a CountingSortu

## ShellSort

- Autor Donald Shell
- Jedná se o vylepšení InsertSortu
- Složitost opět **_O_**(N^2)
- Je podobný CombSortu - taktéž využívá snižující se přírůstek při porovnávání místo standardních "sousedů"
- Výhodou je rychlejší přemístění vysokých a nízkých hodnot
- Zásadní problém pro efektivitu je volba délky "skoku"
- Shell doporučoval n/2 a vzdálenost delegovat po polovinách
  - Nevýhoda u porovnávání sudý/lichý soused - porovnávají se až jako poslední
- Byly i další varianty:
  - Hibbard - posoupnost **2^k - 1**, složitost **_O_**(N^2/3)
  - Sedgewick - **9×4^i - 9×2^i**, složitost **_O_**(N^4/3)
  - Fibonacci umocněný dvojnásobkem **1/1.0618**
- Nejlepší výsledek:
  - Marcin Ciura
  - Posloupnost **1, 4, 10, 23, 57, 132, 301, 701, 1750**
  - ... a dále **skok×2.2**
- **[Názorná ukázka](https://www.algoritmy.net/article/154/Shell-sort)**
