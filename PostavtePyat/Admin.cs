using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostavtePyat
{
    internal class Admin : User
    {
        public Admin()
        {
        }

        public Admin(string name, string login, string password) : base(name, login, password)
        {

        }

        public void BanUser(User user)
        {
            //Ban user
        }

        public void RazbanUser(User user)
        {
            //do
        }
    }
}
