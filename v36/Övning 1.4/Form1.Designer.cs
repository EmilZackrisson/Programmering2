namespace Övning_1._4
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTeckensnitt = new System.Windows.Forms.TextBox();
            this.cbxFet = new System.Windows.Forms.CheckBox();
            this.cbxKursiv = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbxUnderstruket = new System.Windows.Forms.CheckBox();
            this.tbxStorlek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 167);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teckensnitt";
            // 
            // tbxTeckensnitt
            // 
            this.tbxTeckensnitt.Location = new System.Drawing.Point(16, 222);
            this.tbxTeckensnitt.Name = "tbxTeckensnitt";
            this.tbxTeckensnitt.Size = new System.Drawing.Size(100, 20);
            this.tbxTeckensnitt.TabIndex = 2;
            // 
            // cbxFet
            // 
            this.cbxFet.AutoSize = true;
            this.cbxFet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFet.Location = new System.Drawing.Point(16, 248);
            this.cbxFet.Name = "cbxFet";
            this.cbxFet.Size = new System.Drawing.Size(44, 17);
            this.cbxFet.TabIndex = 5;
            this.cbxFet.Text = "Fet";
            this.cbxFet.UseVisualStyleBackColor = true;
            // 
            // cbxKursiv
            // 
            this.cbxKursiv.AutoSize = true;
            this.cbxKursiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKursiv.Location = new System.Drawing.Point(16, 272);
            this.cbxKursiv.Name = "cbxKursiv";
            this.cbxKursiv.Size = new System.Drawing.Size(55, 17);
            this.cbxKursiv.TabIndex = 6;
            this.cbxKursiv.Text = "Kursiv";
            this.cbxKursiv.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(241, 289);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbxUnderstruket
            // 
            this.cbxUnderstruket.AutoSize = true;
            this.cbxUnderstruket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnderstruket.Location = new System.Drawing.Point(16, 295);
            this.cbxUnderstruket.Name = "cbxUnderstruket";
            this.cbxUnderstruket.Size = new System.Drawing.Size(87, 17);
            this.cbxUnderstruket.TabIndex = 8;
            this.cbxUnderstruket.Text = "Understruket";
            this.cbxUnderstruket.UseVisualStyleBackColor = true;
            // 
            // tbxStorlek
            // 
            this.tbxStorlek.Location = new System.Drawing.Point(216, 222);
            this.tbxStorlek.Name = "tbxStorlek";
            this.tbxStorlek.Size = new System.Drawing.Size(100, 20);
            this.tbxStorlek.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Storlek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxStorlek);
            this.Controls.Add(this.cbxUnderstruket);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbxKursiv);
            this.Controls.Add(this.cbxFet);
            this.Controls.Add(this.tbxTeckensnitt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTeckensnitt;
        private System.Windows.Forms.CheckBox cbxFet;
        private System.Windows.Forms.CheckBox cbxKursiv;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox cbxUnderstruket;
        private System.Windows.Forms.TextBox tbxStorlek;
        private System.Windows.Forms.Label label2;
    }
}

