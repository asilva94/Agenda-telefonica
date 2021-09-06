using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace agend_1
{
    public partial class insert_edit : Form
    {
        int indice;
        public insert_edit()
        {
            InitializeComponent();
            NewList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_edit_Click(object sender, EventArgs e)
        {
            //exit
            this.Close();
        }

        private void insert_edit_Load(object sender, EventArgs e)
        {

        }

        private void NewList()
        {
            list_contacts.Items.Clear();

            foreach (contacts contact in cl_geral.LISTA_CONTACTS)
            {
                list_contacts.Items.Add(contact.name + "(" + contact.number + ")" + "-" + contact.ende);

            }

            //atualiza registros
            number_regist.Text = "Registros: " + list_contacts.Items.Count;

            // impedir /del
            delete.Enabled = false;
            

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            //inserir um novo dado

            //verificação dos campos
            if (text_num.Text=="" || text_name.Text== "" || text_ende.Text == "")
            {
                MessageBox.Show("Favor preencher todos os campos!");
                return;
            }

            //verica se existe algum dado igual
            foreach(contacts contact in cl_geral.LISTA_CONTACTS)
            {
                if (contact.name == text_name.Text &&
                    contact.number == text_num.Text &&
                    contact.ende == text_ende.Text)

                {
                    MessageBox.Show("ERRO! Item existente.");
                    return;

                }
            }

            
                
                
            //gravar novo dado
            cl_geral.SalvarNovo(text_name.Text, text_num.Text, text_ende.Text);

            NewList();

            //reseta o texto escrito
            text_name.Text = "";
            text_num.Text = "";
            text_ende.Text = "";
            text_name.Focus();
                

        }

        private void list_contacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selecionar
            //verificar
            if (list_contacts.SelectedIndex == -1) return;
            indice = list_contacts.SelectedIndex;
            
            delete.Enabled = true;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            //apagar seleção
            cl_geral.LISTA_CONTACTS.RemoveAt(indice);
            cl_geral.SalvarPasta();
            NewList();


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ende_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {

        }
    }
}
