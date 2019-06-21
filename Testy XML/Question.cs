using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy_XML {
    class Question {
        private readonly string Name;
        private List<Answer> Answers;
        public Question(string name, List<Answer> answers) {
            Name = name;
            Answers = answers;
        }
    }
}
