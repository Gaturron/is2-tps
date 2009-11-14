using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace POC
{
    public class Sensor
    {       
        private String _nombre;        
        private String _estado;
        private TR _owner;
        private static readonly Random random = new Random();               

        public Sensor(String nombre)
        {
            _nombre = nombre;            
            _owner = null;
            _estado = "Desactivado";
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }        

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public TR Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public void ActivarSensor() 
        {
            _estado = "Activado";            
        }

        public void RomperSensor()
        {
            _estado = "Roto";            
        }

        public void DesactivarSensor()
        {
            _estado = "Desactivado";
        }

        public void EnviarInformacion()
        {
            if (_estado != "Roto" && _estado != "Desactivado")
            {
                int data = random.Next(0, 100);
                Owner.RecibirInformacionSensor(_nombre + " " + data);
            }
        }
    }
}
