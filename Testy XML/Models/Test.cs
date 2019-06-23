using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Testy_XML.Models {
    class Test {
        private string _name;
        private string _author;
        private string _level;
        private int _time;
        private List<Question> _questions;
        public Test(string name, string author, string level, int time, List<Question> questions) {
            _name = name;
            _author = author;
            _level = level;
            _time = time;
            _questions = questions;
        }
        public void Save() {
            XmlWriter xmlWriter = XmlWriter.Create(_name + ".xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("test");
        }
    }
}
