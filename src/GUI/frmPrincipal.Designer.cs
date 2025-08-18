namespace GUI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnMenuLateral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnJogos = new System.Windows.Forms.Button();
            this.btnAdicionarJogo = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.pnMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuLateral
            // 
            this.pnMenuLateral.BackColor = System.Drawing.Color.Gray;
            this.pnMenuLateral.Controls.Add(this.btnConfiguracoes);
            this.pnMenuLateral.Controls.Add(this.btnAdicionarJogo);
            this.pnMenuLateral.Controls.Add(this.btnJogos);
            this.pnMenuLateral.Controls.Add(this.label1);
            this.pnMenuLateral.Controls.Add(this.pictureBox1);
            this.pnMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnMenuLateral.Name = "pnMenuLateral";
            this.pnMenuLateral.Size = new System.Drawing.Size(200, 450);
            this.pnMenuLateral.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "GAME LIBRARY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnJogos
            // 
            this.btnJogos.BackColor = System.Drawing.Color.Transparent;
            this.btnJogos.FlatAppearance.BorderSize = 0;
            this.btnJogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogos.ForeColor = System.Drawing.Color.White;
            this.btnJogos.Location = new System.Drawing.Point(33, 137);
            this.btnJogos.Name = "btnJogos";
            this.btnJogos.Size = new System.Drawing.Size(112, 29);
            this.btnJogos.TabIndex = 2;
            this.btnJogos.Text = "Jogos";
            this.btnJogos.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarJogo
            // 
            this.btnAdicionarJogo.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarJogo.FlatAppearance.BorderSize = 0;
            this.btnAdicionarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarJogo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarJogo.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarJogo.Location = new System.Drawing.Point(36, 190);
            this.btnAdicionarJogo.Name = "btnAdicionarJogo";
            this.btnAdicionarJogo.Size = new System.Drawing.Size(112, 29);
            this.btnAdicionarJogo.TabIndex = 3;
            this.btnAdicionarJogo.Text = "Adicionar jogo";
            this.btnAdicionarJogo.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracoes.Location = new System.Drawing.Point(36, 243);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(112, 29);
            this.btnConfiguracoes.TabIndex = 4;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnMenuLateral);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.pnMenuLateral.ResumeLayout(false);
            this.pnMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenuLateral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnAdicionarJogo;
        private System.Windows.Forms.Button btnJogos;
    }
}