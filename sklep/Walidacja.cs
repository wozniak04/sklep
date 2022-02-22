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
        private bool nazwa { get; set; }
        private bool pass1 { get; set; }
        private bool pass2 { get; set; }
        private bool mail { get; set; }
        public bool checkUsername(string username)
        {
            var Data = new DataAcces();
            if (!Data.getUser(username))
            {
                this.nazwa = true;
                return true;
            }
            this.nazwa = false;
            return false;
        }
        public bool checkPassword(string haslo)
        {
            if (Regex.IsMatch(haslo, "[a-zA-z0-9]{8,}"))
            {
                this.pass1 = true;
                return true;
            }
            pass1 = false;
            return false;
           
        }
        public bool check2Password(string haslo1,string haslo2)
        {
            if (haslo1 == haslo2)
            {
                pass2 = true;
                return true;
            }
            pass2 = false;
            return false;
        }
        public bool checkemail(string email)
        {
            if (Regex.IsMatch(email, "^[a-zA-Z0-9]+[@]+[a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}"))
            {
                mail = true;
                return true;
            }
            mail = false;
            return false;
        }
        public bool czygit()
        {
            if(nazwa==true && pass1==true && pass2==true && mail == true)
            {
                return true;
            }
            return false;
        }
    }
}
