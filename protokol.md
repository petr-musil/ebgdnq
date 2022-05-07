# Technická dokumentace
### Scénář
Organizace závodů v bojovém umění
### Požadavky v bodech (odrážkách)
Databáze závodníků - iniciály - jméno a příjmení, email, věk (důležité), technický stupeň (také důležité) (10kyu...1kyu 1 dan .. 10 dan) (E. g. Jan, Novak, novakjan@ban.cz)
Závod -> omezení věkem i technickým stupněm (shora, zdola) - podmínky při plánování závodu
      - po spuštění se lidé rozlosují do tříčlenných skupin
	    vítěz skupiny se utká systém pavouk pool A winner 1 jde na pool F winner 2 a pool A winner 2 jde na pool F winner 1 a vítěžové párů se perou spolu, čímž se určí celkový vítěz
		pavouk až do úplného vítěze
		hraje se na dva body- M D K T
		X je remíza, E je remíza, OO je odstoupení ze závodu
		pokud jsou v poolu je dva, tak postupují oba, ale musí se zjistit, kdo je první a kdo je druhý
		lichý počet poolů znamená, že jeden pool jde až do dalšího kola
		v poolu rozhoduje počet výher a při shodě pak počet bodů
		zápas trvá 3 minuty (zajímavost) hraje se na body, případně ale může být remíza, nebo jeden bod a vyprší čas
### Technologie
Desktop: .NET Core 5.0, SQLite3
Data: Python
### Časový plán
|Úkol|Doba zpracování|
|----|---------------|
|Výběr typu aplikace a použitých technologií|04:00|
|Příprava repozitáře a verzování kódu|03:00|
|Návrh prvků (dialogů) pro interakci s uživatelem|02:00|
|Řešení datové perzistence - co ukládat a jakým způsobem|02:00|
|Vybrání a implementace prvků (knihovna, balíček) pro vizualizaci|04:00|
|Vytvoření dialogových oken|04:00|
|Logika pro CRUD operace (včetně práce s DB) a validace zápasníků|04:00|
|Vygenerování turnaje|02:00|
|Zadání výsledků do turnaje - dialogy a validace|04:00|
|Vytvoření testovacích dat (předvyplněné databáze) - zápasníci|04:00|
|Uložení průběhu a výsledku zápasu|03:00|
|Vytvoření testovacích dat (předvyplněné databáze) - zápasy|03:00|
### Otázky
- Robustnost - dá se předpokládat chyba v datech?
- Bezpečnost - dá se předpokládat ovlivňování výsledku?
- Co musí být trvale uloženo (průběh turnaje, výsledek turnaje)
- Zajímá nás věk nebo datum narození
- Škálování - turnaj má 6 skupin, takže moje řešení počítá s 12 až 18 zápasníky. 8 skupiny? Nebo dokonce lichý počet skupin?
- Škálování - kolik zápasníků je obvykle v databázi méně jak 12 znemožní vůbec naplánovat turnaj - počet ovlivní vhodnost řešení, např. jak mazat zápasníky?

