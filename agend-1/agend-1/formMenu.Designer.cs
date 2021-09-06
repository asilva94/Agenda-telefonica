
namespace agend_1
{
    partial class formMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.insert_edit = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Call Of Ops Duty", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGENDA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // insert_edit
            // 
            this.insert_edit.Location = new System.Drawing.Point(115, 75);
            this.insert_edit.Name = "insert_edit";
            this.insert_edit.Size = new System.Drawing.Size(202, 58);
            this.insert_edit.TabIndex = 1;
            this.insert_edit.Text = "Inserir";
            this.insert_edit.UseVisualStyleBackColor = true;
            this.insert_edit.Click += new System.EventHandler(this.insert_edit_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(115, 150);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(202, 58);
            this.search.TabIndex = 2;
            this.search.Text = "Pesquisar";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(115, 229);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(202, 58);
            this.exit.TabIndex = 3;
            this.exit.Text = "Sair";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // version
            // 
            this.version.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.version.Location = new System.Drawing.Point(3, 296);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(427, 23);
            this.version.TabIndex = 4;
            this.version.Text = "version";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.version.Click += new System.EventHandler(this.version_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 11);
            this.label2.TabIndex = 5;
            this.label2.Text = "By AVS.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.version);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.search);
            this.Controls.Add(this.insert_edit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA";
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_edit;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label label2;
    }
}

