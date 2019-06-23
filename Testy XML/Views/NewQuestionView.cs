using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testy_XML.Interfaces;

namespace Testy_XML {
    public partial class NewQuestion : UserControl, INewQuestionView {
        private List<string> _answers;
        private List<bool> _isTrueAnswer;
        public NewQuestion() {
            InitializeComponent();
            _answers = new List<string>();
            _isTrueAnswer = new List<bool>();
        }

        public string QuestionName { get { return questionTextBox.Text; } }

        public List<string> Answers {
            get {
                _answers.Clear();
                if(aTextBox.Text.Length>0) {
                    _answers.Add(aTextBox.Text);
                }
                if (bTextBox.Text.Length > 0) {
                    _answers.Add(bTextBox.Text);
                }
                if (cCheckBox.Checked && cTextBox.Text.Length>0) {
                    _answers.Add(aTextBox.Text);
                }
                if (dCheckBox.Checked && dTextBox.Text.Length > 0) {
                    _answers.Add(aTextBox.Text);
                }
                if (eCheckBox.Checked && eTextBox.Text.Length > 0) {
                    _answers.Add(aTextBox.Text);
                }
                if (fCheckBox.Checked && fTextBox.Text.Length > 0) {
                    _answers.Add(aTextBox.Text);
                }
                return _answers;
            }
        }

        public List<bool> IsTrueAnswer {
            get {
                _isTrueAnswer.Clear();
                if (aTrue.Checked)
                    _isTrueAnswer.Add(true);
                else
                    _isTrueAnswer.Add(false);
                if (bTrue.Checked)
                    _isTrueAnswer.Add(true);
                else
                    _isTrueAnswer.Add(false);
                if (cCheckBox.Checked && cTrue.Checked)
                    _isTrueAnswer.Add(true);
                else if (cCheckBox.Checked && !cTrue.Checked)
                    _isTrueAnswer.Add(false);
                if (dCheckBox.Checked && dTrue.Checked)
                    _isTrueAnswer.Add(true);
                else if (dCheckBox.Checked && !dTrue.Checked)
                    _isTrueAnswer.Add(false);
                if (eCheckBox.Checked && eTrue.Checked)
                    _isTrueAnswer.Add(true);
                else if (eCheckBox.Checked && !eTrue.Checked)
                    _isTrueAnswer.Add(false);
                if (fCheckBox.Checked && fTrue.Checked)
                    _isTrueAnswer.Add(true);
                else if (fCheckBox.Checked && !fTrue.Checked)
                    _isTrueAnswer.Add(false);
                return _isTrueAnswer;
            }
        }
    }
}
