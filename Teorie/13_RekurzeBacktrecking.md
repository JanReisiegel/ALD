# 13. Co víte o rekurzi a backtracingu?

## Rekurze

Rekurzivní algoritmus je ten, který volá sám sebe k vyřešení problému.

### Pravidla

1. Musí být definována podmínka ukončení algoritmu
2. V každém kroku rekurze musí dojít ke zjednodušení problému
3. V algoritmu se nejprve musí ověřit, zda nenastala koncová situace. Když ne, provede se kerrzivní krok.

### Typy rekurze

- Přímá rekurze
  - Funkce volá sama sebe
- Nepřímá rekurze
  - Vzájemné volání několika funkcí
  - Např.: funkce **A** volá funkci **B**, ta volá funkci **C** a ta opět funkci **A**

### Vlastnosti rekurze

Pomocí rekurze můžeme:

- Definovat nekonečnou množinu objektů konečným příkazem
- Nekonečný počet výpočtů popsat pomocí konečného rekurzivního programu
- Vytvořit poměrně krátké (přehledné) a efektivn programy

Nevýhody:

- Každé volání podprogramu nutně způsobí:
  - uložení lokálních proměnných na zásobníku
  - předání parametrů a návratové adresy
  - skok do podprogramu
  - uvolnění lokálních proměnných
  - návrat z podprogramu

### Kdy použít rekurzi?

- Rozhodnutí je vždy na programátorovi
- Není vhodné ji použít:
  - máme-li k dispozici iterativní algoritmus se stejnou složitostí.
  - chová-li se rekurzivní řešení nestabilně (např.: občasné zauzlení)
  - pokud počet rekurzivních volání roste rychleji než lineárně
- Existuje způsob jak neefektivitu snížit => Tabelace
  - Neefektivnita způsobená opakovaným voláním se stejnými vstupy
  - Spočítaný výsledek se poprvé uloží (např.: do pole)
  - Místo opakovaného volání se přečte
  - Rozměr pole == počet parametrů rekurzívního volání
  - Dá se použít i hašovací tabulka
  - Kompromis mezi časovou a paměťovou náročností

## Backtracking - prohledávání s návratem

8 dam
