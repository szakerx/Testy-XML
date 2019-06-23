using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy_XML {
    class Question {
        public string Name { get; set; }
        public List<Answer> Answers { get; set; }
        public Question(string name, List<Answer> answers) {
            Name = name;
            Answers = answers;
        }
    }
}
