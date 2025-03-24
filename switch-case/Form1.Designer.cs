
namespace switch_case
{
    partial class frmSwitch
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCodigoInserido = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(240, 42);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(259, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Insira um código de 1 a 6 ";
            // 
            // txtCodigoInserido
            // 
            this.txtCodigoInserido.Location = new System.Drawing.Point(298, 89);
            this.txtCodigoInserido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoInserido.Name = "txtCodigoInserido";
            this.txtCodigoInserido.Size = new System.Drawing.Size(148, 26);
            this.txtCodigoInserido.TabIndex = 1;
            this.txtCodigoInserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescricao
            // 
            this.lblDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescricao.Location = new System.Drawing.Point(298, 141);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(148, 33);
            this.lblDescricao.TabIndex = 2;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Black;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Yellow;
            this.btnEnviar.Location = new System.Drawing.Point(274, 198);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(195, 73);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar Código";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 692);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCodigoInserido);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSwitch";
            this.Text = "Condicional Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCodigoInserido;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnEnviar;
    }
}

