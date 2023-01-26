using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostavtePyat
{
    internal class Tester
    {
        private List<User> users = new List<User>();
        private List<Question> question = new List<Question>();
        private User currentUser;

        static void Main(string[] args)
        {

        }

        public void addUser(string name, string login, string password, string repeation) =>
            users.Add(new User(name, login, password));
        
        public User findUser(string logim, string password) =>
            users.Where(u => u.login == logim & u.password == password).FirstOrDefault();

        public void save() { }
        public void load() { }

        public List<Question> getResults() =>
            question;
    }
}
