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
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());
            conn.Open();

            SqlCommand query = new SqlCommand($"select Nazwa from Uzytkownik Where Nazwa='{nazwa}' ",conn);
            SqlDataReader reader = query.ExecuteReader();

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
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["uzytkownicy"].ConnectionString.ToString());
            conn.Open();

            SqlCommand query = new SqlCommand($"select Haslo from Uzytkownik Where Haslo='{haslo}' ", conn);
            SqlDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                hasloD = reader.GetString(0);
            }

            conn.Close();

            if (hasloD.Length > 0)
                return true;
            
            return false;
        }



    }
}
