using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agend_1
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
            //carregar 
            cl_geral.CriaLista();

            //apresenta version
            version.Text = cl_geral.versao;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void version_Click(object sender, EventArgs e)
        {

        }

        private void formMenu_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            //sair da aplicação 

            //pergunta se pretende sair
            if (MessageBox.Show("Deseja sair?", "Sair" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void insert_edit_Click(object sender, EventArgs e)
        {
            // abrir formulario editar/inserir

            insert_edit formulario = new insert_edit();
            formulario.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            //abrir pesquisa
            TextP f = new TextP();
            f.ShowDialog();

            //ao fechar vai verificar o cancelamento
            if (f.cancelado) return;

            // abrir o quadro com o resultado das pesquisas
            Result ff = new Result(f.texto);
            ff.ShowDialog();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
