
namespace agend_1
{
    partial class insert_edit
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
            this.exit_edit = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_num = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.list_contacts = new System.Windows.Forms.ListBox();
            this.num_regist = new System.Windows.Forms.Label();
            this.number_regist = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.text_ende = new System.Windows.Forms.TextBox();
            this.endereço = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_edit
            // 
            this.exit_edit.Location = new System.Drawing.Point(409, 440);
            this.exit_edit.Name = "exit_edit";
            this.exit_edit.Size = new System.Drawing.Size(108, 37);
            this.exit_edit.TabIndex = 3;
            this.exit_edit.Text = "Fechar";
            this.exit_edit.UseVisualStyleBackColor = true;
            this.exit_edit.Click += new System.EventHandler(this.exit_edit_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(43, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(82, 23);
            this.name.TabIndex = 6;
            this.name.Text = "Nome:";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(125, 9);
            this.text_name.MaxLength = 50;
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(301, 23);
            this.text_name.TabIndex = 0;
            this.text_name.TextChanged += new System.EventHandler(this.text_name_TextChanged);
            // 
            // text_num
            // 
            this.text_num.Location = new System.Drawing.Point(125, 61);
            this.text_num.MaxLength = 20;
            this.text_num.Name = "text_num";
            this.text_num.Size = new System.Drawing.Size(121, 23);
            this.text_num.TabIndex = 1;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(43, 61);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(82, 23);
            this.number.TabIndex = 7;
            this.number.Text = "Telefone:";
            this.number.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(125, 94);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(108, 37);
            this.Salvar.TabIndex = 2;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // list_contacts
            // 
            this.list_contacts.FormattingEnabled = true;
            this.list_contacts.ItemHeight = 15;
            this.list_contacts.Location = new System.Drawing.Point(28, 160);
            this.list_contacts.Name = "list_contacts";
            this.list_contacts.Size = new System.Drawing.Size(489, 259);
            this.list_contacts.TabIndex = 9;
            this.list_contacts.SelectedIndexChanged += new System.EventHandler(this.list_contacts_SelectedIndexChanged);
            // 
            // num_regist
            // 
            this.num_regist.Location = new System.Drawing.Point(28, 134);
            this.num_regist.Name = "num_regist";
            this.num_regist.Size = new System.Drawing.Size(315, 23);
            this.num_regist.TabIndex = 8;
            this.num_regist.Text = "Lista de Numeros registrados:";
            this.num_regist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.num_regist.Click += new System.EventHandler(this.label1_Click);
            // 
            // number_regist
            // 
            this.number_regist.Location = new System.Drawing.Point(28, 422);
            this.number_regist.Name = "number_regist";
            this.number_regist.Size = new System.Drawing.Size(97, 23);
            this.number_regist.TabIndex = 10;
            this.number_regist.Text = "Registros: 0";
            this.number_regist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(295, 440);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 37);
            this.delete.TabIndex = 4;
            this.delete.Text = "Apagar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // text_ende
            // 
            this.text_ende.Location = new System.Drawing.Point(125, 35);
            this.text_ende.MaxLength = 100;
            this.text_ende.Name = "text_ende";
            this.text_ende.Size = new System.Drawing.Size(301, 23);
            this.text_ende.TabIndex = 11;
            this.text_ende.TextChanged += new System.EventHandler(this.ende_TextChanged);
            // 
            // endereço
            // 
            this.endereço.Location = new System.Drawing.Point(43, 35);
            this.endereço.Name = "endereço";
            this.endereço.Size = new System.Drawing.Size(82, 23);
            this.endereço.TabIndex = 12;
            this.endereço.Text = "Endereço: ";
            this.endereço.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.endereço.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // insert_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 489);
            this.ControlBox = false;
            this.Controls.Add(this.text_ende);
            this.Controls.Add(this.endereço);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.number_regist);
            this.Controls.Add(this.num_regist);
            this.Controls.Add(this.list_contacts);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.text_num);
            this.Controls.Add(this.number);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.name);
            this.Controls.Add(this.exit_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "insert_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA - INSERIR/EDITAR";
            this.Load += new System.EventHandler(this.insert_edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_edit;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_num;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.ListBox list_contacts;
        private System.Windows.Forms.Label num_regist;
        private System.Windows.Forms.Label number_regist;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox ende;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_ende;
        private System.Windows.Forms.Label endereço;
        
    }
}