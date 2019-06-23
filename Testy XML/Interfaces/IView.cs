using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy_XML.Interfaces {
    public interface IView {
        INewQuestionView NewQuestionView { get; set; }
        event Action<string, List<string>, List<bool>> AddQuestion;
        event Action<string, string, string, int> SaveTest;
        List<string> Questions { get; set; }
    }
}
