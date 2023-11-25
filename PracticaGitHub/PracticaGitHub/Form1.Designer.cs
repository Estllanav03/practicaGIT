namespace PracticaGitHub
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCoste = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.rdUrgente = new System.Windows.Forms.RadioButton();
            this.rdOrdinario = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(684, 425);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(142, 63);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Location = new System.Drawing.Point(374, 465);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(55, 20);
            this.lblCoste.TabIndex = 10;
            this.lblCoste.Text = "Coste:";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(376, 200);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(52, 20);
            this.lblTexto.TabIndex = 9;
            this.lblTexto.Text = "Texto:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(432, 462);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(118, 26);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(380, 237);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(434, 133);
            this.txtTelegrama.TabIndex = 6;
            // 
            // rdUrgente
            // 
            this.rdUrgente.AutoSize = true;
            this.rdUrgente.Location = new System.Drawing.Point(499, 411);
            this.rdUrgente.Name = "rdUrgente";
            this.rdUrgente.Size = new System.Drawing.Size(92, 24);
            this.rdUrgente.TabIndex = 12;
            this.rdUrgente.TabStop = true;
            this.rdUrgente.Text = "Urgente";
            this.rdUrgente.UseVisualStyleBackColor = true;
            // 
            // rdOrdinario
            // 
            this.rdOrdinario.AutoSize = true;
            this.rdOrdinario.Location = new System.Drawing.Point(380, 411);
            this.rdOrdinario.Name = "rdOrdinario";
            this.rdOrdinario.Size = new System.Drawing.Size(98, 24);
            this.rdOrdinario.TabIndex = 13;
            this.rdOrdinario.TabStop = true;
            this.rdOrdinario.Text = "Ordinario";
            this.rdOrdinario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.rdOrdinario);
            this.Controls.Add(this.rdUrgente);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCoste);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTelegrama);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.RadioButton rdUrgente;
        private System.Windows.Forms.RadioButton rdOrdinario;
    }
}

