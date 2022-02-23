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

            var query = new SqlCommand($"select Nazwa from Uzytkownik Where Nazwa='{nazwa}' ",conn);
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
        public bool insert(string nazwa,string haslo,string email)
        {
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());
            conn.Open();
            var query = new SqlCommand($"insert into Uzytkownik (Nazwa,Haslo,Email) values ('{nazwa}','{haslo}','{email}')", conn);
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



    }
}
