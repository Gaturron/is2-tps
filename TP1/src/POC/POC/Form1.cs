using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace POC
{
    public partial class Form1 : Form
    {
        public BindingList<TR> lista_trs = new BindingList<TR>(); 
        public BindingList<Modelo> lista_modelos = new BindingList<Modelo>();
        public BindingList<SMS> lista_paquetes = new BindingList<SMS>();
        private static readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
                     
            grid_TRs.DataSource = lista_trs;                        
            grid_Modelos.DataSource = lista_modelos;
            grid_mensajes.DataSource = lista_paquetes;   
        }               

        private void btn_nuevoModelo_Click(object sender, EventArgs e)
        {
            NuevoModelo form = new NuevoModelo();            
            Modelo temp_modelo = form.GetModelo();
            lista_modelos.Add(temp_modelo);
        }       

        private void btn_gentrs_Click(object sender, EventArgs e)
        {
            btn_bajarconectividad.Enabled = true;
            btn_sensoratr.Enabled = true;
            btn_rompersensores.Enabled = true;

            lista_trs.Clear();

            int cant_trs = random.Next(1, 10);
            List<String> Tipos = new List<string>();
            Tipos.Add("Presion");
            Tipos.Add("Temperatura");
            Tipos.Add("Humedad");
            Tipos.Add("Viento");
            Tipos.Add("Luz");

            for (int i = 0; i < cant_trs; i++) 
            {
                TR temp_tr = new TR("TR"+i);
                List<String> tipos_temp = Tipos.ToList();

                int cant_sensores = random.Next(1, 5);

                for (int k = 0; k < cant_sensores; k++)
                {                        
                    int index_sens = random.Next(0,tipos_temp.Count());

                    Sensor temp_sens = new Sensor(tipos_temp[index_sens]);

                    Boolean activar;
                    int act_rand = random.Next(0, 2);
                    if(act_rand == 1) { activar = true;} else { activar = false;}

                    temp_tr.AgregarSensor(temp_sens,activar);

                    tipos_temp.RemoveAt(index_sens);
                }                               
 
                lista_trs.Add(temp_tr);                 
            }                               
        }

        private void btn_rompersensores_Click(object sender, EventArgs e)
        {
            int cant_tr_romper = random.Next(0, lista_trs.Count());

            for (int i = 0; i < cant_tr_romper; i++)
            {                 
                int index_tr_romper = random.Next(0, lista_trs.Count());                

                TR tr_a_romper = lista_trs[index_tr_romper];

                if (tr_a_romper.GetSensoresSanos().Count > 0)
                {
                    int cant_sensores_romper = random.Next(1, tr_a_romper.GetSensoresSanos().Count);

                    for (int k = 0; k < cant_sensores_romper; k++)
                    {
                        while (true)
                        {
                            int index_sensor_romper = random.Next(0, tr_a_romper.getSensores().Count());
                            if (tr_a_romper.getSensores()[index_sensor_romper].Estado != "Roto")
                            {
                                tr_a_romper.RomperSensor(index_sensor_romper);
                                break;
                            }
                        }
                    }
                }
            }

            grid_TRs.Refresh();
        }

        private void btn_bajarconectividad_Click(object sender, EventArgs e)
        {
            double porc = random.NextDouble();

            for (int i = 0; i < lista_trs.Count; i++)
            {
                lista_trs[i].CondicionServicio = Convert.ToInt32(lista_trs[i].CondicionServicio * porc);
            }

            grid_TRs.Refresh();
        }

        private void btn_sensoratr_Click(object sender, EventArgs e)
        {
            btn_traec.Enabled = true;

            foreach (TR t in lista_trs)
            {
                foreach (Sensor s in t.getSensores())
                {
                    s.EnviarInformacion();
                }
            }

            grid_TRs.Refresh();
        }

        private List<TR> MixList(List<TR> inputList)
        {
            List<TR> randomList = new List<TR>();
            if (inputList.Count == 0)
                return randomList;

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                randomList.Add(inputList[randomIndex]); //add it to the new, random list<
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            //clean up            
            return randomList; //return the new random list
        }

        private void btn_traec_Click(object sender, EventArgs e)
        {
            List<TR> lista_trs_mix = MixList(lista_trs.ToList());

            for (int k = 0; k < lista_trs_mix.Count; k++)
            {
                TR t = lista_trs_mix[k];
                int tries = 5;

                SMS mensaje_recibido = t.EnviarInformacion();
                txt_log.Text = "Send Request for Info to " + t.Nombre + "\r\n" + txt_log.Text;
                txt_log.Refresh();
                while (mensaje_recibido == null)
                {
                    if (tries == 0)
                    {
                        txt_log.Text = "Timeout." + t.Nombre + " seems to be down.\r\n" + txt_log.Text;
                        txt_log.Refresh();
                        break;
                    }
                    else
                    {
                        tries--;
                        int delay1 = random.Next(0, 2);
                        Thread.Sleep(delay1 * 1000);
                        int randomNumber = random.Next(0, 100);
                        int sim = (t.CondicionServicio + randomNumber) / 2;
                        if (sim > 50)
                        {
                            SMS noack_sms = new SMS("0 NoAck");
                            int delay2 = random.Next(0, 2);
                            Thread.Sleep(delay2 * 1000);
                            txt_log.Text = "Send NoAck for Info to " + t.Nombre + "\r\n" + txt_log.Text;
                            txt_log.Refresh();
                            mensaje_recibido = t.RecibirNoAck(noack_sms);
                        }
                        else
                        {
                            txt_log.Text = "Send NoAck for Info to " + t.Nombre + "\r\n" + txt_log.Text;
                            txt_log.Refresh();
                            mensaje_recibido = t.RecibirNoAck(null);
                        }
                    }
                }
                if (mensaje_recibido != null)
                {
                    lista_paquetes.Add(mensaje_recibido);
                    txt_log.Text = "Received info from " + t.Nombre + "\r\n" + txt_log.Text;
                    txt_log.Refresh();                    
                }
                grid_TRs.Refresh();
                grid_mensajes.Refresh();
            }
            txt_log.Text = "End Receiving info.\r\n" + txt_log.Text;
            txt_log.Refresh();
        }        
    }
}
