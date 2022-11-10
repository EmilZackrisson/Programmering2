namespace Övning_1._2
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
            this.tbxRad = new System.Windows.Forms.TextBox();
            this.tbxKol = new System.Windows.Forms.TextBox();
            this.tbxVärde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnÄndra = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbxRad
            // 
            this.tbxRad.Location = new System.Drawing.Point(393, 68);
            this.tbxRad.Name = "tbxRad";
            this.tbxRad.Size = new System.Drawing.Size(42, 20);
            this.tbxRad.TabIndex = 1;
            // 
            // tbxKol
            // 
            this.tbxKol.Location = new System.Drawing.Point(441, 68);
            this.tbxKol.Name = "tbxKol";
            this.tbxKol.Size = new System.Drawing.Size(52, 20);
            this.tbxKol.TabIndex = 2;
            // 
            // tbxVärde
            // 
            this.tbxVärde.Location = new System.Drawing.Point(390, 110);
            this.tbxVärde.Name = "tbxVärde";
            this.tbxVärde.Size = new System.Drawing.Size(100, 20);
            this.tbxVärde.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kolumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Värde";
            // 
            // btnÄndra
            // 
            this.btnÄndra.Location = new System.Drawing.Point(390, 136);
            this.btnÄndra.Name = "btnÄndra";
            this.btnÄndra.Size = new System.Drawing.Size(100, 23);
            this.btnÄndra.TabIndex = 8;
            this.btnÄndra.Text = "Ändra";
            this.btnÄndra.UseVisualStyleBackColor = true;
            this.btnÄndra.Click += new System.EventHandler(this.btnÄndra_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(357, 331);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 412);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnÄndra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxVärde);
            this.Controls.Add(this.tbxKol);
            this.Controls.Add(this.tbxRad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxRad;
        private System.Windows.Forms.TextBox tbxKol;
        private System.Windows.Forms.TextBox tbxVärde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnÄndra;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

