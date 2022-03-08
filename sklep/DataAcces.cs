using System.Data;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace sklep
{
    public class DataAcces
    {
        public bool getUser(string nazwa)
        {
            string nazwaD = "";
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());
            conn.Open();

            var query = new SqlCommand($"select Nazwa from Uzytkownik Where Nazwa='{nazwa}' ", conn);
            var reader = query.ExecuteReader();

            while (reader.Read())
            {
                nazwaD = reader.GetString(0);
            }

            conn.Close();
            if (nazwaD.Length > 0)
                return true;

            return false;


        }

        public bool getpassword(string haslo)
        {
            string hasloD = "";
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());
            conn.Open();

            var query = new SqlCommand($"select Haslo from Uzytkownik Where Haslo='{haslo}' ", conn);
            var reader = query.ExecuteReader();

            while (reader.Read())
            {
                hasloD = reader.GetString(0);
            }

            conn.Close();

            if (hasloD.Length > 0)
                return true;

            return false;
        }
        public bool insert(string nazwa, string haslo, string email,byte[] zdjecie)
        {
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());
            conn.Open();
            var query = new SqlCommand($"insert into Uzytkownik (Nazwa,Haslo,Email,Zdjecie) values ('{nazwa}','{haslo}','{email}',@Zdjecie)", conn);
            query.Parameters.AddWithValue("@Zdjecie",zdjecie);
            query.ExecuteNonQuery();

            conn.Close();
            if (!this.test(nazwa))
            {
                return false;
            }
            return true;
        }
        private bool test(string nazwa)
        {
            string nazwad = "";

            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());
            conn.Open();
            var query = new SqlCommand($"select Nazwa from Uzytkownik Where Nazwa='{nazwa}' ", conn);
            var reader = query.ExecuteReader();

            while (reader.Read())
            {
                nazwad = reader.GetString(0);
            }

            conn.Close();

            if (nazwad.Length > 0)
                return true;
            return false;
        }

        private bool test2(string nazwa)
        {
            string nazwad = "";

            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());
            conn.Open();
            var query = new SqlCommand($"select NazwaUzytkownika from Zamowienia Where NazwaUzytkownika='{nazwa}' ", conn);
            var reader = query.ExecuteReader();

            while (reader.Read())
            {
                nazwad = reader.GetString(0);
            }

            conn.Close();

            if (nazwad.Length > 0)
                return true;
            return false;
        }

        public string nazwa(int licznik)
        {
            string produkt="";
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());
            
            conn.Open();
            var query = new SqlCommand($"select Nazwa From Oferty Where idOferty={licznik} ", conn);
            var reader = query.ExecuteReader();
            if (reader.Read())
            {
                produkt = reader["Nazwa"].ToString();               
            }
            conn.Close();
            return produkt;
        }
        public string cena(int licznik)
        {
            string produkt = "";
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());

            conn.Open();
            var query = new SqlCommand($"select Cena From Oferty Where idOferty={licznik} ", conn);
            var reader = query.ExecuteReader();
            if (reader.Read())
            {
                produkt = reader["Cena"].ToString();
            }
            conn.Close();
            return produkt;
        }

        public string opis(int licznik)
        {
            string produkt = "";
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());

            conn.Open();
            var query = new SqlCommand($"select Opis From Oferty Where idOferty={licznik} ", conn);
            var reader = query.ExecuteReader();
            if (reader.Read())
            {
                produkt = reader["Opis"].ToString();
            }
            conn.Close();
            return produkt;
        }

        public bool insertOferty(string nazwa,byte[] zdjecie,string oferta, int cena)
        {
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());
            conn.Open();
            var query = new SqlCommand($"insert into Zamowienia (NazwaUzytkownika,ZdjecieOferty,NazwaOferty,CenaOferty) values ('{nazwa}',@zdjecie,'{oferta}',{cena})", conn);
            query.Parameters.AddWithValue("@zdjecie",zdjecie);
            query.ExecuteNonQuery();

            conn.Close();
            if (!this.test2(nazwa))
            {
                return false;
            }
            return true;
        }

        public byte[] getZdjecie(string nazwa) {

            byte[] zdjecie=null;
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());

            conn.Open();
            var query = new SqlCommand($"select Zdjecie From Uzytkownik Where Nazwa='{nazwa}' ", conn);
            var reader = query.ExecuteReader();
            if (reader.Read())
            {
                zdjecie = (byte[])reader["Zdjecie"];
            }
            conn.Close();
            return zdjecie;
        }



    }
}
