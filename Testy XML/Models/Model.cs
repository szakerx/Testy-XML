using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy_XML.Models {
    class Model {
        private List<Question> _questions;
        public Model() {
            _questions = new List<Question>();
        }
        public List<string> GetQuestions(string questionName,List<string> answers, List<bool> isTrueAnswer) {
            foreach (var x in _questions)
                if (x.Name == questionName) {
                    List<string> returnSame = new List<string>();
                    foreach (var y in _questions)
                        returnSame.Add(y.Name);
                    return returnSame;
                }
            List<Answer> localAnwers = new List<Answer>();
            List<string> localQuestions = new List<string>();
            for (int i = 0; i < answers.Count; i++) {
                localAnwers.Add(new Answer(answers[i], ((uint)i + 1), isTrueAnswer[i]));
            }
            _questions.Add(new Question(questionName, localAnwers));
            foreach (var v in _questions)
                localQuestions.Add(v.Name);
            return localQuestions;
        }
        public void SaveTest(string name,string author, string level,int time) {
            Test test = new Test(name, author, level, time, _questions);
            test.Save();
        }
    }
}
