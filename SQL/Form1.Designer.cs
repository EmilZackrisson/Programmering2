namespace SQL
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
            this.btnSök = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbxResultat = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(246, 11);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(75, 23);
            this.btnSök.TabIndex = 0;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbxResultat
            // 
            this.lbxResultat.FormattingEnabled = true;
            this.lbxResultat.Location = new System.Drawing.Point(13, 53);
            this.lbxResultat.Name = "lbxResultat";
            this.lbxResultat.ScrollAlwaysVisible = true;
            this.lbxResultat.Size = new System.Drawing.Size(308, 121);
            this.lbxResultat.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Personnummer",
            "FNamn",
            "ENamn",
            "Född"});
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 197);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbxResultat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSök);
            this.Name = "Form1";
            this.Text = "SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbxResultat;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

