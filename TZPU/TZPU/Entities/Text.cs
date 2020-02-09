using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TZPU.Entities
{
    public class Text : Data
    {

        private String _text;
        public Text(String text)
        {
            _text = text;
        }
        public override string PrintQuestion()
        {
            return _text;
        }
    }
}