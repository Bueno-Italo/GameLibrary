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
                CarregarPlataformas();
            }
            catch (Exception ex) 
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

        private void frmCadastroPlataforma_Load(object sender, EventArgs e)
        {
            CarregarPlataformas();
            dgvPlataformas.CellClick += new DataGridViewCellEventHandler(dgvPlataformas_CellContentClick);

        }
        private void CarregarPlataformas()
        {
            try
            {
                Conexao conn = new Conexao();
                BLLPlataforma bll = new BLLPlataforma(conn);
                dgvPlataformas.DataSource = bll.ListarTodas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar plataformas: " + ex.Message);
            }
        }

        private void dgvPlataformas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPlataformas.Rows[e.RowIndex];

                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Selecione uma plataforma para alterar.");
                    return;
                }

                Plataforma modelo = new Plataforma();
                modelo.Id = int.Parse(txtId.Text);
                modelo.Nome = txtNome.Text.Trim();

                Conexao conn = new Conexao();
                BLLPlataforma bll = new BLLPlataforma(conn);
                bll.Alterar(modelo);

                CarregarPlataformas();

                txtId.Clear();
                txtNome.Clear();
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar plataforma: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           //pictureBox1.Image = Image.FromFile("Resources/joystick.png");
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Selecione uma plataforma para excluir.");
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    "Tem certeza que deseja excluir esta plataforma?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );

                if (confirm == DialogResult.Yes)
                {
                    Plataforma modelo = new Plataforma();
                    modelo.Id = int.Parse(txtId.Text);

                    Conexao conn = new Conexao();
                    BLLPlataforma bll = new BLLPlataforma(conn);
                    bll.Excluir(modelo.Id);
                    MessageBox.Show("Plataforma excluída com sucesso!");
                    txtId.Clear();
                    txtNome.Clear();
                    CarregarPlataformas();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir plataforma: " + ex.Message);
            }
        }
    }
}
