using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabuadacomLoop
{
    public partial class frmTabuadaLoop : Form
    {
        public frmTabuadaLoop()
        {
            InitializeComponent();
        }

        private void btnExecutarTabuada_Click(object sender, EventArgs e)
        {
            int numeroInserido = Convert.ToInt32(txtNumero.Text);

            //limpar lista 
            lstTabuada.Items.Clear();

            // adcionar a tabuada para o numero inserido
            for (int i = 1; i < 11; i++)
            {
                lstTabuada.Items.Add(numeroInserido + "X" + i + "=" + (numeroInserido * i));
            }

        }

    }
}
