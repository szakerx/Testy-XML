using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testy_XML.Presenters;
using Testy_XML.Interfaces;
using Testy_XML.Models;

namespace Testy_XML {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IView view = new View();
            Model model = new Model();
            ViewPresenter viewPresenter = new ViewPresenter(model, view);
            NewQuestionPresenter newQuestionPresenter = new NewQuestionPresenter(model, view.NewQuestionView);
            Application.Run((View)view);
        }
    }
}
