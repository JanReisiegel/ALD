# 15. Popište princip ShakerSortu a HeapSortu

## ShakerSort

- ShakerSort je vylepšením BubbleSortu
- Řadí vstupní pole v obou směrech
- Stejně jako BubbleSort používá vnořené cykly - hlavní iterační a vedlejší porovnávací
  - Hlavní iterační probíhá jen n/2 krát
  - Vedlejší porovnávací jsou dva - každý z opačného konce pole
- Jeho složitost je **_O_**(N^2)
- Řeší lépe problém zajíců a želv

## HeapSort - řazení haldou

- Složitost je logaritmicka **_O_**(log(N))
- Pokud pro haldu použijeme vstupní pole, nemá žádné paměťové nároky
- Má horší možnosti paralelizace
- Halda se využívá k tomu, aby se do ní uspořádali prvky vstupní posloupnosti
- Poté se z haldy vybere uzel do výstupní posloupnosti, tzn. minimální uzel (kořen -> nejvyšší hodnota)
- následně se provede rekonstrukce haldy
- Postup se opakuje tak, že další odebraný uzel (kořen nové haldy) se umístí na začátek výstupní posloupnosti
- Výsledkem je setříděná výstupní posloupnost
