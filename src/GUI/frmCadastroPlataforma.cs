using GUI.BLL;
using GUI.DAL;
using GUI.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroPlataforma : Form
    {
        public frmCadastroPlataforma()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Plataforma modelo = new Plataforma();
                modelo.Nome = txtNome.Text.Trim();

                DAL.Conexao conn = new Conexao();
                BLLPlataforma bll = new BLLPlataforma(conn);
                bll.Inserir(modelo);

                MessageBox.Show("plataforma cadastrada com sucesso!");
                txtNome.Clear();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close(); //Fecha form atual
        }
    }
}
