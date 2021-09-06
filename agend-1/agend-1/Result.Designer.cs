
namespace agend_1
{
    partial class Result
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
            this.fechar = new System.Windows.Forms.Button();
            this.nova_pesquisa = new System.Windows.Forms.Button();
            this.lista_fin = new System.Windows.Forms.ListBox();
            this.number_regist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(506, 249);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(148, 50);
            this.fechar.TabIndex = 0;
            this.fechar.Text = "Sair";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // nova_pesquisa
            // 
            this.nova_pesquisa.Location = new System.Drawing.Point(352, 249);
            this.nova_pesquisa.Name = "nova_pesquisa";
            this.nova_pesquisa.Size = new System.Drawing.Size(148, 50);
            this.nova_pesquisa.TabIndex = 1;
            this.nova_pesquisa.Text = "Nova Pesquisa...";
            this.nova_pesquisa.UseVisualStyleBackColor = true;
            this.nova_pesquisa.Click += new System.EventHandler(this.nova_pesquisa_Click);
            // 
            // lista_fin
            // 
            this.lista_fin.FormattingEnabled = true;
            this.lista_fin.ItemHeight = 15;
            this.lista_fin.Location = new System.Drawing.Point(12, 12);
            this.lista_fin.Name = "lista_fin";
            this.lista_fin.Size = new System.Drawing.Size(642, 229);
            this.lista_fin.TabIndex = 2;
            // 
            // number_regist
            // 
            this.number_regist.Location = new System.Drawing.Point(12, 244);
            this.number_regist.Name = "number_regist";
            this.number_regist.Size = new System.Drawing.Size(248, 23);
            this.number_regist.TabIndex = 12;
            this.number_regist.Text = "Registros: 0";
            this.number_regist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 303);
            this.ControlBox = false;
            this.Controls.Add(this.number_regist);
            this.Controls.Add(this.lista_fin);
            this.Controls.Add(this.nova_pesquisa);
            this.Controls.Add(this.fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESULTADOS";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Button nova_pesquisa;
        private System.Windows.Forms.ListBox lista_fin;
        private System.Windows.Forms.Label number_regist;
    }
}