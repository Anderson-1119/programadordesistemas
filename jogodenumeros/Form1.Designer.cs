
namespace jogodenumeros
{
    partial class FrmJogodeNumeros
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.txtNumeroInserido = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnTentativas = new System.Windows.Forms.Button();
            this.lblAbaixoBotao = new System.Windows.Forms.Label();
            this.lblnumerotentativas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(145, 32);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(501, 32);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Boas vindas ao meu jogo de números";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Red;
            this.lblSubtitulo.Location = new System.Drawing.Point(191, 117);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(400, 22);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "10 tentativas! Insira um numero de 1 a 100.";
            // 
            // txtNumeroInserido
            // 
            this.txtNumeroInserido.Location = new System.Drawing.Point(304, 155);
            this.txtNumeroInserido.Name = "txtNumeroInserido";
            this.txtNumeroInserido.Size = new System.Drawing.Size(105, 20);
            this.txtNumeroInserido.TabIndex = 2;
            this.txtNumeroInserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(195, 396);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(385, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // btnTentativas
            // 
            this.btnTentativas.BackColor = System.Drawing.Color.Red;
            this.btnTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTentativas.ForeColor = System.Drawing.Color.White;
            this.btnTentativas.Location = new System.Drawing.Point(288, 210);
            this.btnTentativas.Name = "btnTentativas";
            this.btnTentativas.Size = new System.Drawing.Size(135, 55);
            this.btnTentativas.TabIndex = 4;
            this.btnTentativas.Text = "Tentativas";
            this.btnTentativas.UseVisualStyleBackColor = false;
            this.btnTentativas.Click += new System.EventHandler(this.btnTentativas_Click);
            // 
            // lblAbaixoBotao
            // 
            this.lblAbaixoBotao.AutoSize = true;
            this.lblAbaixoBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbaixoBotao.Location = new System.Drawing.Point(225, 352);
            this.lblAbaixoBotao.Name = "lblAbaixoBotao";
            this.lblAbaixoBotao.Size = new System.Drawing.Size(266, 24);
            this.lblAbaixoBotao.TabIndex = 5;
            this.lblAbaixoBotao.Text = "Veja quantas tentativas restam:";
            // 
            // lblnumerotentativas
            // 
            this.lblnumerotentativas.AutoSize = true;
            this.lblnumerotentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerotentativas.Location = new System.Drawing.Point(497, 352);
            this.lblnumerotentativas.Name = "lblnumerotentativas";
            this.lblnumerotentativas.Size = new System.Drawing.Size(30, 24);
            this.lblnumerotentativas.TabIndex = 6;
            this.lblnumerotentativas.Text = "10";
            // 
            // FrmJogodeNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnumerotentativas);
            this.Controls.Add(this.lblAbaixoBotao);
            this.Controls.Add(this.btnTentativas);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumeroInserido);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.panel1);
            this.Name = "FrmJogodeNumeros";
            this.Text = "Jogo de Números";
            this.Load += new System.EventHandler(this.FrmJogodeNumeros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txtNumeroInserido;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnTentativas;
        private System.Windows.Forms.Label lblAbaixoBotao;
        private System.Windows.Forms.Label lblnumerotentativas;
    }
}

