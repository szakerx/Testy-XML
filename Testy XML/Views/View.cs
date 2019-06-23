using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testy_XML.Interfaces;

namespace Testy_XML {
    public partial class View : Form,IView {
        public INewQuestionView NewQuestionView { get; set; }
        public List<string> Questions { get { return listBox_Questions.DataSource as List<string>; } set { listBox_Questions.DataSource = value; } }
        public View() {
            InitializeComponent();
            NewQuestionView = newQuestion1;
        }
        public event Action<string,List<string>,List<bool>> AddQuestion;
        public event Action<string, string, string, int> SaveTest;

        private void Button_AddQuestion_Click(object sender, EventArgs e) {
            AddQuestion?.Invoke(NewQuestionView.QuestionName,NewQuestionView.Answers,NewQuestionView.IsTrueAnswer);
        }

        private void ListBox_Questions_MouseDoubleClick(object sender, MouseEventArgs e) {
            //potrzebuje do tego commandera zeby ogaranc polozenie myszy (bedzie ladowac pytanie)
        }

        private void Button_SaveTest_Click(object sender, EventArgs e) {
            SaveTest?.Invoke(textBoxName.Text, textBoxAuthor.Text, textBoxLevel.Text, (int)numericUpDown1.Value);
        }
    }
}
