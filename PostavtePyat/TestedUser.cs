using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostavtePyat
{
    internal class TestedUser : User
    {
        private int questionsCount { get; set; } = 0;
        public int rightAnswers { private get; set; } = 0;

        public TestedUser(string name, string login, string password) : base(name, login, password)
        {

        }

        public void getAnswer(Question question, int answer)
        {
            questionsCount = question.getAnswers().Length;
            rightAnswers = answer;
        }

        public void clear()
        {
            questionsCount = 0;
            rightAnswers = 0;
        }
    }
}
