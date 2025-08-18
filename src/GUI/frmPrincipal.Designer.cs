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
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dsgJogos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsgJogos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuLateral
            // 
            this.pnMenuLateral.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
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
            this.btnJogos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogos.ForeColor = System.Drawing.Color.White;
            this.btnJogos.Location = new System.Drawing.Point(34, 155);
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
            this.btnAdicionarJogo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracoes.Location = new System.Drawing.Point(34, 225);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(112, 29);
            this.btnConfiguracoes.TabIndex = 4;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.btnExcluir);
            this.pnlConteudo.Controls.Add(this.btnEditar);
            this.pnlConteudo.Controls.Add(this.dsgJogos);
            this.pnlConteudo.Controls.Add(this.txtbuscar);
            this.pnlConteudo.Controls.Add(this.label2);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(200, 0);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(600, 450);
            this.pnlConteudo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jogos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtbuscar.Location = new System.Drawing.Point(15, 59);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(573, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.Text = "Search...";
            // 
            // dsgJogos
            // 
            this.dsgJogos.AllowUserToAddRows = false;
            this.dsgJogos.AllowUserToDeleteRows = false;
            this.dsgJogos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dsgJogos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsgJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsgJogos.EnableHeadersVisualStyles = false;
            this.dsgJogos.Location = new System.Drawing.Point(15, 103);
            this.dsgJogos.MultiSelect = false;
            this.dsgJogos.Name = "dsgJogos";
            this.dsgJogos.ReadOnly = true;
            this.dsgJogos.RowHeadersVisible = false;
            this.dsgJogos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsgJogos.Size = new System.Drawing.Size(572, 285);
            this.dsgJogos.TabIndex = 2;
            this.dsgJogos.DefaultCellStyleChanged += new System.EventHandler(this.dataGridView1_DefaultCellStyleChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(375, 405);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 27);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Firebrick;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(484, 405);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 27);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameLibrary";
            this.pnMenuLateral.ResumeLayout(false);
            this.pnMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsgJogos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenuLateral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnAdicionarJogo;
        private System.Windows.Forms.Button btnJogos;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dsgJogos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
    }
}