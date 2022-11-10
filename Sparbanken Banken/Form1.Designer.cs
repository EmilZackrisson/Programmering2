namespace Sparbanken_Banken
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBelopp = new System.Windows.Forms.TextBox();
            this.btnInsättning = new System.Windows.Forms.Button();
            this.btnUttag = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPersonNr = new System.Windows.Forms.TextBox();
            this.tbxRäntesats = new System.Windows.Forms.TextBox();
            this.tbxKredit = new System.Windows.Forms.TextBox();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnUppdateraMedÅrsränta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUttag);
            this.groupBox1.Controls.Add(this.btnInsättning);
            this.groupBox1.Controls.Add(this.tbxBelopp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insättning / Uttag";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistrera);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxKredit);
            this.groupBox2.Controls.Add(this.tbxRäntesats);
            this.groupBox2.Controls.Add(this.tbxPersonNr);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öppna Konto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Belopp";
            // 
            // tbxBelopp
            // 
            this.tbxBelopp.Location = new System.Drawing.Point(94, 17);
            this.tbxBelopp.Name = "tbxBelopp";
            this.tbxBelopp.Size = new System.Drawing.Size(100, 20);
            this.tbxBelopp.TabIndex = 1;
            // 
            // btnInsättning
            // 
            this.btnInsättning.Location = new System.Drawing.Point(119, 82);
            this.btnInsättning.Name = "btnInsättning";
            this.btnInsättning.Size = new System.Drawing.Size(75, 23);
            this.btnInsättning.TabIndex = 2;
            this.btnInsättning.Text = "Insättning";
            this.btnInsättning.UseVisualStyleBackColor = true;
            this.btnInsättning.Click += new System.EventHandler(this.btnInsättning_Click);
            // 
            // btnUttag
            // 
            this.btnUttag.Location = new System.Drawing.Point(119, 110);
            this.btnUttag.Name = "btnUttag";
            this.btnUttag.Size = new System.Drawing.Size(75, 23);
            this.btnUttag.TabIndex = 3;
            this.btnUttag.Text = "Uttag";
            this.btnUttag.UseVisualStyleBackColor = true;
            this.btnUttag.Click += new System.EventHandler(this.btnUttag_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PersonNr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Räntesats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kredit";
            // 
            // tbxPersonNr
            // 
            this.tbxPersonNr.Location = new System.Drawing.Point(94, 17);
            this.tbxPersonNr.Name = "tbxPersonNr";
            this.tbxPersonNr.Size = new System.Drawing.Size(100, 20);
            this.tbxPersonNr.TabIndex = 1;
            // 
            // tbxRäntesats
            // 
            this.tbxRäntesats.Location = new System.Drawing.Point(94, 43);
            this.tbxRäntesats.Name = "tbxRäntesats";
            this.tbxRäntesats.Size = new System.Drawing.Size(100, 20);
            this.tbxRäntesats.TabIndex = 3;
            // 
            // tbxKredit
            // 
            this.tbxKredit.Location = new System.Drawing.Point(94, 69);
            this.tbxKredit.Name = "tbxKredit";
            this.tbxKredit.Size = new System.Drawing.Size(100, 20);
            this.tbxKredit.TabIndex = 4;
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(119, 102);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrera.TabIndex = 5;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(424, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(332, 108);
            this.listBox1.TabIndex = 2;
            // 
            // btnUppdateraMedÅrsränta
            // 
            this.btnUppdateraMedÅrsränta.Location = new System.Drawing.Point(425, 128);
            this.btnUppdateraMedÅrsränta.Name = "btnUppdateraMedÅrsränta";
            this.btnUppdateraMedÅrsränta.Size = new System.Drawing.Size(332, 23);
            this.btnUppdateraMedÅrsränta.TabIndex = 3;
            this.btnUppdateraMedÅrsränta.Text = "Uppdatera Med Årsränta";
            this.btnUppdateraMedÅrsränta.UseVisualStyleBackColor = true;
            this.btnUppdateraMedÅrsränta.Click += new System.EventHandler(this.btnUppdateraMedÅrsränta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 173);
            this.Controls.Add(this.btnUppdateraMedÅrsränta);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUttag;
        private System.Windows.Forms.Button btnInsättning;
        private System.Windows.Forms.TextBox tbxBelopp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxKredit;
        private System.Windows.Forms.TextBox tbxRäntesats;
        private System.Windows.Forms.TextBox tbxPersonNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnUppdateraMedÅrsränta;
    }
}

