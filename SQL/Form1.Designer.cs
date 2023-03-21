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
            this.gbxReg = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEfternamn = new System.Windows.Forms.Label();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPersonnummer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.gbxReg.SuspendLayout();
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
            this.lbxResultat.Size = new System.Drawing.Size(308, 147);
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
            // gbxReg
            // 
            this.gbxReg.Controls.Add(this.btnReg);
            this.gbxReg.Controls.Add(this.label3);
            this.gbxReg.Controls.Add(this.label2);
            this.gbxReg.Controls.Add(this.lblEfternamn);
            this.gbxReg.Controls.Add(this.tbxPersonnummer);
            this.gbxReg.Controls.Add(this.label1);
            this.gbxReg.Controls.Add(this.tbxEfternamn);
            this.gbxReg.Controls.Add(this.tbxFörnamn);
            this.gbxReg.Controls.Add(this.dateTimePicker1);
            this.gbxReg.Location = new System.Drawing.Point(348, 53);
            this.gbxReg.Name = "gbxReg";
            this.gbxReg.Size = new System.Drawing.Size(257, 148);
            this.gbxReg.TabIndex = 5;
            this.gbxReg.TabStop = false;
            this.gbxReg.Text = "Registera";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(89, 17);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(156, 20);
            this.tbxFörnamn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Förnamn:";
            // 
            // lblEfternamn
            // 
            this.lblEfternamn.AutoSize = true;
            this.lblEfternamn.Location = new System.Drawing.Point(6, 43);
            this.lblEfternamn.Name = "lblEfternamn";
            this.lblEfternamn.Size = new System.Drawing.Size(58, 13);
            this.lblEfternamn.TabIndex = 2;
            this.lblEfternamn.Text = "Efternamn:";
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(89, 40);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(156, 20);
            this.tbxEfternamn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personnummer:";
            // 
            // tbxPersonnummer
            // 
            this.tbxPersonnummer.Location = new System.Drawing.Point(89, 66);
            this.tbxPersonnummer.Name = "tbxPersonnummer";
            this.tbxPersonnummer.Size = new System.Drawing.Size(156, 20);
            this.tbxPersonnummer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Födelsedag:";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(170, 119);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Registrera";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 218);
            this.Controls.Add(this.gbxReg);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbxResultat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSök);
            this.Name = "Form1";
            this.Text = "SQL";
            this.gbxReg.ResumeLayout(false);
            this.gbxReg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbxResultat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbxReg;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEfternamn;
        private System.Windows.Forms.TextBox tbxPersonnummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

