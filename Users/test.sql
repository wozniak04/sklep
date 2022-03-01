if not exists (select 1 from dbo.[Uzytkownik])
	begin
		INSERT INTO dbo.[Uzytkownik] (Nazwa,Haslo,Email)
		VALUES ('mikolaj','bigwu123','mikimen@no.pl'),
				('fryderyk','fryta123','frutasd@no.pl'),
				('michal','ruc321123','dawajdogoscicina@no.pl');
	    INSERT INTO dbo.[Oferty] (Nazwa,Cena,Opis)
		VALUES 
		('komputer Cygański',20,'Komputer składany na zamówienie, z wybranych przez klienta dowolnych podzespołów, czas realizacji może wynieść od 1 do 31 dni.' ),
		('komputer dell',2799,'procesor Intel Core i3-10100, karta graficzna zintegrowana, dysk HDD 1 TB, RAM 8 GB.'),
		('komputer gamingowy z allegro',7999,'Komputer gamingowy z allegro, który uciągnie jakąkolwiek grę na najwyższych ustawieniach graficznych, w rozdzielczości 4k. Procesor Intel Core i5 4430, najnowsza 
karta graficzna, Nvidia GeForce GT 1030, dwie kości RAM 2 GB 1333 Mhz.'),
		('komputer strzebielinski',7,'Mocny komputer z procesorem Intel Core i1 1 generacji, kartą graficzną z laptopa, bez ramu wraz z przewiewną obudową. Do zestawu dołączany jest superszybki internet domowy 0,12 Mb/s pobierania.'),
		('komputer xkom',39000,'procesor Intel Core i9-11900K, karta graficzna GeForce RTX 3090, 128 GB pamięci ram 3200 MHz, 2x dysk SSD 2 TB.');
	end
