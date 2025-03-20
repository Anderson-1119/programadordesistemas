using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculodeDesconto
{
    public partial class frmCalculodedesconto : Form
    {
        public frmCalculodedesconto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar preço e percentual de desconto do usuário
                decimal preco = decimal.Parse(txtCompra.Text);
                decimal desconto = decimal.Parse(txtDesconto.Text);

                // Calcular o valor com desconto
                decimal valorDesconto = (preco * desconto) / 100;
                decimal precoFinal = preco - valorDesconto;

                // Exibir o resultado
                lblValorcomDesc.Text = $"R$ {precoFinal:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos para o preço e o desconto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
