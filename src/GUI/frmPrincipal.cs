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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CarregarJogos();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            CarregarJogos(txtbuscar.Text);
        }

        private void CarregarJogos(string filtro = "")
        {
            try
            {
                //DataTable tabela = BLLJogo.Localizar(filtro);
                var bll = new BLLJogo(new Conexao());
                DataTable tabela = bll.Localizar(filtro);
                dsgJogos.DataSource = tabela;

                // Ajustar cabeçalhos
                dsgJogos.Columns["Id"].HeaderText = "ID";
                dsgJogos.Columns["Nome"].HeaderText = "Nome do Jogo";
                dsgJogos.Columns["Plataforma"].HeaderText = "Plataforma";
                dsgJogos.Columns["Genero"].HeaderText = "Gênero";
                dsgJogos.Columns["AnoLancamento"].HeaderText = "Ano";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar jogos: " + ex.Message);
            }
        }
    }
}
