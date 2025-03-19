using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodenumeros
{
    public partial class FrmJogodeNumeros : Form
    {
        int randomNumber;
        int numeroTentativas = 10;
        int palpitedoJogador;
        bool jogoGanho = false;
        string dica; 

        public FrmJogodeNumeros()
        {
            InitializeComponent();
        }

        private void FrmJogodeNumeros_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101); 
        }

        private void btnTentativas_Click(object sender, EventArgs e)
        {
            if (numeroTentativas == 0)
            {
                txtResultado.Text = "voce não tem mais tentativas, o jogo acabou";
                return;
            }
           if(!int.TryParse(txtNumeroInserido.Text, out palpitedoJogador)|| palpitedoJogador < 1 || palpitedoJogador > 100)
            {
                txtResultado.Text = "Favor, insira um numero entre 1 e 100";
                return;
            }
            numeroTentativas--;
            lblnumerotentativas.Text = numeroTentativas.ToString();
            
            if (palpitedoJogador == randomNumber)
            {
                jogoGanho = true;
                dica = "Parabens, voce acertou!";
            }
            else if (palpitedoJogador < randomNumber)
            {
                dica = "o numero do seu palpite é menor que o numero do jogo";
            }
            else
            {
                dica = "o número do seu palpite é maior que o numero do jogo";
            }
            txtResultado.Text = dica;
        }
    }
}
