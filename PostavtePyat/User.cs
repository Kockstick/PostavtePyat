using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostavtePyat
{
    internal class User
    {
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public User()
        {

        }

        public virtual void polimorphizm()
        {

        }

        public User(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
        }

        public bool enter(string login, string password) =>
            (this.login == login & this.password == password);
    }
}
