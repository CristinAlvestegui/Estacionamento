namespace Estacionamento
{
    partial class Saida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Placa = new System.Windows.Forms.MaskedTextBox();
            this.Confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a Placa:";
            // 
            // Placa
            // 
            this.Placa.Location = new System.Drawing.Point(22, 28);
            this.Placa.Mask = "aaa-#a##";
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(86, 20);
            this.Placa.TabIndex = 1;
            this.Placa.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Placa_MaskInputRejected);
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(22, 66);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(85, 28);
            this.Confirmar.TabIndex = 2;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 226);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.Placa);
            this.Controls.Add(this.label1);
            this.Name = "Saida";
            this.Text = "Saida";
            this.Load += new System.EventHandler(this.Saida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Placa;
        private System.Windows.Forms.Button Confirmar;
    }
}