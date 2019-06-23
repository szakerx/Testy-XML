using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testy_XML.Models;
using Testy_XML.Interfaces;

namespace Testy_XML.Presenters {
    class NewQuestionPresenter {
        private Model Model;
        private INewQuestionView NewQuestionView;
        public NewQuestionPresenter(Model model, INewQuestionView newQuestion) {
            Model = model;
            NewQuestionView = newQuestion;
        }
    }
}
