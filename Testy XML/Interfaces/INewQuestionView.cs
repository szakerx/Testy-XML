using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy_XML.Interfaces {
    public interface INewQuestionView {
        string QuestionName { get; }
        List<string> Answers { get; }
        List<bool> IsTrueAnswer { get; }
    }
}
