using GUI.BLL;
using GUI.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Modelo
{
    public partial class frmCadastroPlataforma : Form
    {
        public frmCadastroPlataforma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Criar o modelo e receber os dados da interface
                Plataforma modelo = new Plataforma();
                modelo.Nome = textBox1.Text.Trim(); // 'txtNome' é o TextBox onde o usuário digita o nome

                // 2. Criar conexão com o banco de dados
                Conexao conexao = new Conexao();

                // 3. Criar objeto da BLL e passar o modelo
                BLLPlataforma bll = new BLLPlataforma(conexao);
                bll.Inserir(modelo);

                // 4. Exibir mensagem de sucesso e limpar campo
                MessageBox.Show("Plataforma cadastrada com sucesso!");
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                // 5. Mostrar mensagem de erro, se houver
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
