# 24. Hashování - základní terminologie, princip, asociativní a adresní vyhledávání, hašovací funkce + kolize

## Asociativní vyhledávání

- Hledáme porovnáváním klíčů
- Asociativní pole jako BVS
- Když klíč prvku = hledaný klíč => nalezeno
- Složitost logaritmická **_O_**(log(N))

## Adresní vyhledávání

- Přímé:
  - Hledaný klíč je přímo indexem, adresou v paměti
  - Počet klíčů určuje velikost indexu - náročné na paměť
  - Složitost elementární **_O_**(1)
- Nepřímé
  - Adresu v paměti vypočteme z hledaného klíče
  - Průměrná složitost je opět **_O_**(1)

## Princip Hashování

- **K** množina použitých klíčů
- **U** universum klíčů
- hašování vhodné pro |**K**| << |**U**|
- Dvě fáze:
  1. Výpočet hašovací funkce h(k) (h(k) vypočítá adresu z hodnoty klíče)
  2. Vyřešení kolizí (příklad h(31) -> kolize: index 1 je již obsazen)

## Hašovací funkce + Kolize

- Hašovací funkce je zobrazení z množiny klíčů **K** do množiny adres **A** = <a~min~, a~max~>
- Množiny A, K mají přibližně stejný počet prvků
- Je silně závislá na vlastnostech klíčů a jejich reprezentaci v paměti
- Ideální funkce
  - Výpočetně co nejjednodušší (rychlá)
  - aproximuje náhodnou funkci
  - Využívá rovnoměrně adresní prostor
  - generuje minimum kolizí

Kolizí nazýváme stav kdy pro 2 různé klíče k~1~ != k~2~ platí, že h(k~1~) = h(k~2~)
