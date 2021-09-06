using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace agend_1
{
    public partial class TextP : Form
    {

        public bool cancelado { get; set; }
        public string texto { get; set; }
        public TextP()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            //cancelar
            cancelado = true;
            this.Close();
        }

        private void search_p_Click(object sender, EventArgs e)
        {
            //define o texto 
            if (text_t.Text == "") return;
            texto = text_t.Text;
            cancelado = false;
            this.Close();

        }

        private void text_t_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void text_t_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                search_p_Click(search_p, EventArgs.Empty);
        }
    }
}
