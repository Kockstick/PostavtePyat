using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostavtePyat
{
    internal class Question
    {
        public string text { private get; set; }
        private string[] answers { get; set; }
        private int rightAnswers { get; set; }

        public Question(string text, string[] answers, int right)
        {
            this.text = text;
            this.answers = answers;
            this.rightAnswers = right;
        }

        public string getText() => text;

        public string[] getAnswers() => answers;

        public bool isCorrect(int answer) => true;
    }
}
