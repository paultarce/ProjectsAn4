using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics.Contracts;

namespace AtelierAuto.Models.Generic
{
    public class PlainText
    {
        private string _text;
        private string _setText;
        public string Text { get { return _text; } }

        //public string SetText { get { return null; } set { value = _text; } }
        public string SetText;

        public PlainText()
        {

        }
        public PlainText(string text)
        {
            

            _text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}