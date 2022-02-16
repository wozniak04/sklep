using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace sklep
{
    public class DataAcces
    {
        public string sprlogin(string login)
        {
            using (SqlConnection connection = new SqlConnection(Conn.conn("uzytkownicy")))
            {
                var query = new SqlCommand($"select * from Uzytkownik Where Nazwa='{login}'",connection);
                SqlDataReader wynik;
                wynik = query.ExecuteReader();

                return wynik["Nazwa"].ToString();


            }
        }
    }
}
