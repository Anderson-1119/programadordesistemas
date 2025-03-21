using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraExercicio
{
    public partial class frmCalculadora : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

       private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
        }

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtValor.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtValor.Text += "1";
        }
    

        private void btn2_Click(object sender, EventArgs e)
        {
            txtValor.Text += "2"; 
         }


        private void btn3_Click(object sender, EventArgs e)
        {
            txtValor.Text += "3";
        }
        

        private void btn4_Click(object sender, EventArgs e)
        {
        txtValor.Text += "4";
    
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtValor.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtValor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtValor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtValor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtValor.Text += "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtValor.Text.Contains(","))
                txtValor.Text += ",";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtValor.Text);
            txtValor.Text = "";
            lblOp.Text = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtValor.Text);
            txtValor.Text = "";
            lblOp.Text = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtValor.Text);
            txtValor.Text = "";
            lblOp.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtValor.Text);
            txtValor.Text = "";
            lblOp.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtValor.Text);
                    break;
                     
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtValor.Text);
                break;

                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtValor.Text);
                    break;

                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtValor.Text);
                    break;
            }
            txtValor.Text = Convert.ToString(Resultado);
        }


        private void btnC_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            lblOp.Text = "";
        }
    }
}
