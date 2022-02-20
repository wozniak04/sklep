using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace sklep
{
    class Walidacja
    {
        public string checkUsername(string username)
        {
            var Data = new DataAcces();
            if (Data.getUser(username))
            {
                return "użytkownik o takiej nazwie istnieje";
            }
            return "";
        }
        public string checkPassword(string haslo)
        {
            if (!Regex.IsMatch(haslo, "^[a-zA-Z0,9]{8,}^"))
                return "hasło powinno zawierać 8 znaków";
            if (!Regex.IsMatch(haslo, "^[a-z]{1,}^"))
                return "hasło powinno zawierać chociaż 1 mały znak";
            if (!Regex.IsMatch(haslo, "^[A-Z]{1,}^"))
                return "hasło powinno zawierać chociaż 1 duży znak";
            if (!Regex.IsMatch(haslo, "^[0-9]{1,}^"))
                return "hasło powinno zawierać chociaż jedną cyfre";
            return "";
        }
        public bool check2Password(string haslo1,string haslo2)
        {
            if (haslo1 == haslo2)
                return true;
            return false;
        }
    }
}
