
namespace CalculodeDesconto
{
    partial class frmCalculodedesconto
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
            this.lblcalculo = new System.Windows.Forms.Label();
            this.lblValorcompra = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblValorcomDesc = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcalculo
            // 
            this.lblcalculo.AutoSize = true;
            this.lblcalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalculo.Location = new System.Drawing.Point(180, 24);
            this.lblcalculo.Name = "lblcalculo";
            this.lblcalculo.Size = new System.Drawing.Size(354, 25);
            this.lblcalculo.TabIndex = 0;
            this.lblcalculo.Text = "Sistema de Cálculo de Desconto";
            // 
            // lblValorcompra
            // 
            this.lblValorcompra.AutoSize = true;
            this.lblValorcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorcompra.Location = new System.Drawing.Point(100, 110);
            this.lblValorcompra.Name = "lblValorcompra";
            this.lblValorcompra.Size = new System.Drawing.Size(206, 20);
            this.lblValorcompra.TabIndex = 1;
            this.lblValorcompra.Text = "Insira o valor da compra ";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(100, 163);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(148, 20);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Insira o desconto";
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(351, 112);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(183, 20);
            this.txtCompra.TabIndex = 3;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(351, 163);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(106, 20);
            this.txtDesconto.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(100, 307);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(265, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Valor da compra com Desconto:";
            // 
            // lblValorcomDesc
            // 
            this.lblValorcomDesc.AutoSize = true;
            this.lblValorcomDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorcomDesc.Location = new System.Drawing.Point(387, 307);
            this.lblValorcomDesc.Name = "lblValorcomDesc";
            this.lblValorcomDesc.Size = new System.Drawing.Size(19, 20);
            this.lblValorcomDesc.TabIndex = 6;
            this.lblValorcomDesc.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(359, 216);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 48);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCalculodedesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(739, 382);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValorcomDesc);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblValorcompra);
            this.Controls.Add(this.lblcalculo);
            this.Name = "frmCalculodedesconto";
            this.Text = "Cálculo de Desconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcalculo;
        private System.Windows.Forms.Label lblValorcompra;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblValorcomDesc;
        private System.Windows.Forms.Button btnCalcular;
    }
}

