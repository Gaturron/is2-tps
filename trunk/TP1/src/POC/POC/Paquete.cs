using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POC
{
    public class Paquete
    {
        private String _mensaje;
        private String _trackid;
        private static readonly Random random = new Random();

        public Paquete(string mensaje,TR tr)
        {
            _mensaje = mensaje;

            _trackid = tr.Nombre;            
        }

        public String GetTrackId()
        {
            return _trackid;
        }

        override public String ToString()
        {
            return _trackid + " " + _mensaje;
        }
    }
}
