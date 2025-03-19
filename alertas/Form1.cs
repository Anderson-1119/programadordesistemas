using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alertas
{
    public partial class frmAlertas : Form
    {
        public frmAlertas()
        {
            InitializeComponent();
        }

        private void btnAlertaSimples_Click(object sender, EventArgs e)
        {
            MessageBox.Show("esse é um alerta simples","Com titulo");
        }

        private void btnAlertaRobusto_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("vamos programar um sistema?", 
                                "Titulo aqui",
                                MessageBoxButtons.YesNo,   MessageBoxIcon.Question); 
            if(resposta == DialogResult.Yes)
            {
                MessageBox.Show("respondeu que sim");
            } else if (resposta == DialogResult.No)
            {
                MessageBox.Show("respondeu que não");
            }
        }
    }
}
