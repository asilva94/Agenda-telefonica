
namespace agend_1
{
    partial class TextP
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
            this.search_p = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_t = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // search_p
            // 
            this.search_p.Location = new System.Drawing.Point(176, 57);
            this.search_p.Name = "search_p";
            this.search_p.Size = new System.Drawing.Size(90, 23);
            this.search_p.TabIndex = 1;
            this.search_p.Text = "Pesquisar";
            this.search_p.UseVisualStyleBackColor = true;
            this.search_p.Click += new System.EventHandler(this.search_p_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titulo de Pesquisa:";
            // 
            // text_t
            // 
            this.text_t.Location = new System.Drawing.Point(17, 28);
            this.text_t.MaxLength = 60;
            this.text_t.Name = "text_t";
            this.text_t.Size = new System.Drawing.Size(249, 23);
            this.text_t.TabIndex = 0;
            this.text_t.TextChanged += new System.EventHandler(this.text_t_TextChanged);
            this.text_t.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_t_KeyDown);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(80, 57);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(90, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // TextP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 85);
            this.ControlBox = false;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.text_t);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_p);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PESQUISA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_t;
        private System.Windows.Forms.Button cancel;
    }
}