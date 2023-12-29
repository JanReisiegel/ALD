# 14. Sorting - co to je, jejich dělení podle typu dat, BogoSort, zajíci a želvy

## Sorting - Řazení

Algoritmy, sloužící k uspořádání dat

Dělení:

- Vnější - v případě rozsáhlých dat načítaných průběžně z disku
- Vnitřní - Používáme pro data, lterá lze najednou uchovat v operační paměti

## BogoSort

Také znám jako RandomSort, MonkeySort, nejlépe jako StupidSort. Jedná se onejhorří algoritmus. Jeho složitost je **_O_**(N×N!).

Princip:

1. zjistí zda data nejsou seřazena
2. Pokud ne, náhodně prohází prvky a pokračuje bodem 1
3. Pokud ano, došel ke správnému cíli (heureka)

## Zajíci

Nejrychleji seřazené prvky

## Želvy

Prvky na které se musí nejdéle čekat
