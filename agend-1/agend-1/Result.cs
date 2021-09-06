using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace agend_1
{
    public partial class Result : Form
    {
        string texto;
        public Result(string texto)
        {
            InitializeComponent();
            //texto pesquisa
            this.texto = texto.ToUpper();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            //
            ExecutPesq();

        }

        private void ExecutPesq()
        {
            //realiza a pesquisa
            List<contacts> lista_resul = new List<contacts>();

            foreach(contacts contacts in cl_geral.LISTA_CONTACTS)
            {
                if(contacts.name.ToUpper().Contains(texto) ||
                    contacts.number.ToUpper().Contains(texto) ||
                    contacts.ende.ToUpper().Contains(texto)) 
                {
                    lista_resul.Add(contacts);
                }
            }
            //apresenta os resultados
            lista_fin.Items.Clear();
            foreach (contacts contacts in lista_resul)
                lista_fin.Items.Add(contacts.name + "(" + contacts.number + ")" + "-" + contacts.ende);


            number_regist.Text = "Registros: " + lista_fin.Items.Count;
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            // FECHAR
            this.Close();
        }

        private void nova_pesquisa_Click(object sender, EventArgs e)
        {
            //pedir novo texto
            TextP f = new TextP();
            f.ShowDialog();

            // se for fechado
            if (f.cancelado) return;

            texto = f.texto.ToUpper();

            ExecutPesq();
        }
    }
}
