if not exists (select 1 from dbo.[Uzytkownik])
	begin
		INSERT INTO dbo.[Uzytkownik] (Nazwa,Haslo,Email)
		VALUES ('mikolaj','bigwu123','mikimen@no.pl'),
				('fryderyk','fryta123','frutasd@no.pl'),
				('michal','ruc321123','dawajdogoscicina@no.pl')
	end
