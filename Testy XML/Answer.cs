using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy_XML {
    class Answer {
        private string Text;
        private uint Number;
        private bool Correct;
        public Answer(string text, uint number, bool correct) {
            Text = text;
            Number = number;
            Correct = correct;
        }
    }
}
