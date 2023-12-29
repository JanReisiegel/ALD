# 11. Definice algoritmu, jeho vlastnosti

## Algoritmus

Algoritmus je postup, jak řešit daný problém, abychom dospěli od zadaný ćh vstupních dat k požadovanému výsledku. Skládá se z _kroků algoritmu_, které jsou určenými činnostmi. Tyto kroky se také nazývají _příkazy_.

Vlastnosti:

- Hromadnost (obecnost)
  - Pracuje nad obecnou množinou dat
- Determinovanost (určitost)
  - Každý stav algoritmu je jednoznačně určen z výsledků předchozího stavu
- Konečnost
  - Pro konečnou množinu dat, dojde v rozumném čase k výsledku
- Rezultativnost (korektnost)

### Hromadnost

- Algoritmus řeší celou přesně vymezenou třídu konkrétních problémů
- liší se **pouze** vstupní hodnoty
- algoritmus není sestrojen pouze na jediný problém, je sestrojen na celou řadu problémů

### Determinovanost

- Jednoznačnost či určitost
- Přechod do následujícího stavu je jednoznačně určen výsledkem stavu předchozího
- Algoritmus je složen ze na sebe navazujících kroků
- Každý krok je charakterizován jako přechod z jednoho stavu do jiného
- Každý stav je určen zpracovávanými daty.
- Je pevně určeno, který krok bude následovat
- Při každé realizaci daného algoritmu dostaneme tentýž výsledek pro stejné vstupní hodnoty

### Konečnost

- Výpočet se ukončí v **_rozumném_** čase
- Realizace algoritmu končí po konečném počtu kroků požadovaným výsledkem

### Rezultativnost

- Korektnost
- Výpočet končí pro libovolná korektní data správným výsledkem

## Kritéria dělení algoritmů

- Iterativní
  - opakování části kódu
- Rekurzivní
  - Volání sebe sama
  - Přehledný kód, ale ne vždy vhodný
  - Lze jej převést do iterativní podoby
  - Někdy to řeší kompilátor
- Deterministické
  - V každém kroku má jedinou možnost jak pokračovat dále
  - Konečný automat, jednoznačné přechody, konečné stavy
- Nedeterministické
  - V Některém kroku má více možnostípokračování
  - Větvení závisí na logice i na datech
  - Skončí v konečném stavu, lale nemá jednoznačnou cestu
- Sériové (sekvenční)
  - Jednotlivé kroky za sebou
- Paralelní
  - Souběžné vykonávání (např.: ve více vláknech)
- Distribuovaný
  - Vícevrstvé architektury, kód běží ve více strojích
