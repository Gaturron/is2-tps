using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POC
{
    public class Modelo
    {
        private String _nombre;
        private String _formula;
 
        public Modelo(String nombre, String formula)
        {
            _nombre = nombre;
            _formula = formula;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Formula
        {
            get { return _formula; }
            set { _formula = value; }
        }
    }
}
