using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testy_XML.Models;
using Testy_XML.Interfaces;

namespace Testy_XML.Presenters {
    class ViewPresenter {
        private Model model;
        private IView view;
        public ViewPresenter(Model xmodel, IView xview) {
            model = xmodel;
            view = xview;
            view.AddQuestion += View_AddQuestion;
            view.SaveTest += View_SaveTest;
        }

        private void View_SaveTest(string arg1, string arg2, string arg3, int arg4) {
            model.SaveTest(arg1, arg2, arg3, arg4);
        }

        private void View_AddQuestion(string questionName, List<string> answers, List<bool> isTrueAnswer) {
            view.Questions = model.GetQuestions(questionName, answers, isTrueAnswer);
        }
    }
}
