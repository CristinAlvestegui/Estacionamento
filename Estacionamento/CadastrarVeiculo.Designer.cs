namespace Estacionamento
{
    partial class CadastrarVeiculo
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
            this.Placa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cor = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Placa
            // 
            this.Placa.Location = new System.Drawing.Point(302, 108);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(142, 20);
            this.Placa.TabIndex = 0;
            this.Placa.TextChanged += new System.EventHandler(this.Placa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastre sua Placa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe o Modelo:";
            // 
            // Modelo
            // 
            this.Modelo.Location = new System.Drawing.Point(302, 239);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(142, 20);
            this.Modelo.TabIndex = 3;
            this.Modelo.TextChanged += new System.EventHandler(this.Modelo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Informe a Cor:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Cor
            // 
            this.Cor.Location = new System.Drawing.Point(302, 423);
            this.Cor.Name = "Cor";
            this.Cor.Size = new System.Drawing.Size(142, 20);
            this.Cor.TabIndex = 5;
            this.Cor.TextChanged += new System.EventHandler(this.Cor_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.BackgroundImage = global::Estacionamento.Properties.Resources.MicrosoftTeams_image__2_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.Location = new System.Drawing.Point(271, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 142);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Estacionamento.Properties.Resources.MicrosoftTeams_image;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(248, -9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 111);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Estacionamento.Properties.Resources.MicrosoftTeams_image__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(211, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(338, 142);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(671, 403);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(117, 35);
            this.Salvar.TabIndex = 9;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // CadastrarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Cor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Placa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "CadastrarVeiculo";
            this.Text = "CadastrarVeiculo";
            this.Load += new System.EventHandler(this.CadastrarVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Placa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Modelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Salvar;
    }
}