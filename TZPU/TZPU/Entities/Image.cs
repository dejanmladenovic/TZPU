using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TZPU.Entities
{
    public class Image : Data
    {
        private string _image;
        public Image(String image)
        {
            _image = image;
        }

        public override string PrintQuestion()
        {
            return _image;
        }
    }
}