using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POC
{
    public class SMS
    {
        private String _datos;        

        public SMS()
        {
            _datos = "";
        }

        public SMS(String text)
        {            
            _datos = text;
        }

        public string Datos
        {
            get { return _datos; }
        }

    }
}
