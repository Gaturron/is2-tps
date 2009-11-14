using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POC
{
    public partial class NuevoModelo : Form
    {
        private Modelo last_modelo;

        public NuevoModelo()
        {
            InitializeComponent();            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            last_modelo = new Modelo(txt_nombre.Text, txt_formula.Text);
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Modelo GetModelo()
        {
            this.ShowDialog();        
            return last_modelo;
        }
    }
}
