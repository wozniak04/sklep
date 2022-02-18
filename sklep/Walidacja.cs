using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return "git";
        }
    }
}
