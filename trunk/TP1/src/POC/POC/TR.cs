using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace POC
{
    public class TR
    {
        private String _nombre;        
        private List<Sensor> _sensores;
        private Dictionary<String,int> _infoRecolectada = new Dictionary<string,int>();        
        private int _condicionDelServicio;
        private static readonly Random random = new Random();        
        private Paquete ultimo_paquete;

        public TR(String nombre)
        {
            _nombre = nombre;            
            _sensores = new List<Sensor>();
            
            int randomNumber = random.Next(0, 100);
            _condicionDelServicio = randomNumber;                        
        }

        public TR(String nombre, List<Sensor> sensores)
        {
            _nombre = nombre;            
            _sensores = sensores;
            
            int randomNumber = random.Next(0, 100);
            _condicionDelServicio = randomNumber;            
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }        

        public string InfoRecolectada
        {
            get { return FormatData(_infoRecolectada); }            
        }

        public int CondicionServicio
        {
            get { return _condicionDelServicio; }
            set { _condicionDelServicio = value; }
        }

        public string Sensores
        {
            get 
            {
                string ret = "";
                foreach (Sensor s in _sensores)
                {
                    ret += s.Nombre + " " +s.Estado + " | ";
                }
                return ret;
            }            
        }

        public List<Sensor> getSensores()
        {
            return _sensores;
        }

        public void AgregarSensor(Sensor s,Boolean activado)
        {
            if (activado)
            {
                s.ActivarSensor();
            }

            s.Owner = this;
            _sensores.Add(s);            
        }     

        public void RomperSensor(int i)
        {
            _sensores[i].RomperSensor();            
        }

        public void ActivarSensor(int i)
        {
            _sensores[i].ActivarSensor();
        }

        public Boolean TodosSensoresRotos()
        {
            for (int i = 0; i < _sensores.Count; i++)
            {               
                if (_sensores[i].Estado != "Roto")
                {
                    return false;
                }
            }
            return true;
        }

        public List<int> GetSensoresSanos()
        {
            List<int> ret = new List<int>();
            for (int i = 0; i < _sensores.Count; i++)
            {
                if (_sensores[i].Estado != "Roto")
                {
                    ret.Add(i);
                }
            }
            return ret;
        }

        public SMS EnviarInformacion()
        {
            Paquete nuevoPaquete = new Paquete(FormatData(_infoRecolectada),this);
            return EnviarPaquete(nuevoPaquete);
        }

        public SMS EnviarPaquete(Paquete paq)
        {
            ultimo_paquete = paq;

            int randomNumber = random.Next(0, 100);

            int sim = (_condicionDelServicio + randomNumber) / 2;
           
            if (sim > 50)
            {
                SMS nuevoSMS = new SMS(paq.ToString());

                int delay = random.Next(0, 2);
                Thread.Sleep(delay * 1000);

                _infoRecolectada.Clear();
                return nuevoSMS;
            }
            else
            {
                return null;
            }            
        }

        public SMS RecibirNoAck(SMS noack)
        {
            if (noack != null)
            {
                string[] separators = new string[1] { " " };
                string[] splitted = noack.Datos.Split(separators, 2, StringSplitOptions.None);

                if (splitted[1] == "NoAck")
                {
                    return EnviarPaquete(ultimo_paquete);
                }
                else
                {
                    return null;
                }
            }
            else 
            {
                return null;
            }
        }

        public string FormatData(Dictionary<String, int> dicc)
        {
            string ret = "";

            foreach (string k in dicc.Keys)
            {
                ret += k + " " + dicc[k] + " | ";
            }

            return ret;
        }

        public void RecibirInformacionSensor(String msg)
        {
            string[] separators = new string[1] { " " };
            string[] splitted = msg.Split(separators,2,StringSplitOptions.None);

            _infoRecolectada[splitted[0]] = Convert.ToInt16(splitted[1]);
        }               
    }
}
