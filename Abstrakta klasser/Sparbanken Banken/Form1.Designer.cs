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
            this.gbxInsättningUttag = new System.Windows.Forms.GroupBox();
            this.btnUttag = new System.Windows.Forms.Button();
            this.btnInsättning = new System.Windows.Forms.Button();
            this.tbxBelopp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxÖppnaKonto = new System.Windows.Forms.GroupBox();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.tbxKredit = new System.Windows.Forms.TextBox();
            this.tbxRäntesats = new System.Windows.Forms.TextBox();
            this.tbxPersonNr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbx1 = new System.Windows.Forms.ListBox();
            this.btnUppÅrsränta = new System.Windows.Forms.Button();
            this.gbxInsättningUttag.SuspendLayout();
            this.gbxÖppnaKonto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInsättningUttag
            // 
            this.gbxInsättningUttag.Controls.Add(this.btnUttag);
            this.gbxInsättningUttag.Controls.Add(this.btnInsättning);
            this.gbxInsättningUttag.Controls.Add(this.tbxBelopp);
            this.gbxInsättningUttag.Controls.Add(this.label1);
            this.gbxInsättningUttag.Location = new System.Drawing.Point(12, 12);
            this.gbxInsättningUttag.Name = "gbxInsättningUttag";
            this.gbxInsättningUttag.Size = new System.Drawing.Size(200, 129);
            this.gbxInsättningUttag.TabIndex = 0;
            this.gbxInsättningUttag.TabStop = false;
            this.gbxInsättningUttag.Text = "Insättning/Uttag";
            // 
            // btnUttag
            // 
            this.btnUttag.Location = new System.Drawing.Point(119, 96);
            this.btnUttag.Name = "btnUttag";
            this.btnUttag.Size = new System.Drawing.Size(75, 23);
            this.btnUttag.TabIndex = 3;
            this.btnUttag.Text = "Uttag";
            this.btnUttag.UseVisualStyleBackColor = true;
            this.btnUttag.Click += new System.EventHandler(this.btnUttag_Click);
            // 
            // btnInsättning
            // 
            this.btnInsättning.Location = new System.Drawing.Point(119, 67);
            this.btnInsättning.Name = "btnInsättning";
            this.btnInsättning.Size = new System.Drawing.Size(75, 23);
            this.btnInsättning.TabIndex = 2;
            this.btnInsättning.Text = "Insättning";
            this.btnInsättning.UseVisualStyleBackColor = true;
            this.btnInsättning.Click += new System.EventHandler(this.btnInsättning_Click);
            // 
            // tbxBelopp
            // 
            this.tbxBelopp.Location = new System.Drawing.Point(77, 20);
            this.tbxBelopp.Name = "tbxBelopp";
            this.tbxBelopp.Size = new System.Drawing.Size(117, 20);
            this.tbxBelopp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Belopp";
            // 
            // gbxÖppnaKonto
            // 
            this.gbxÖppnaKonto.Controls.Add(this.btnRegistrera);
            this.gbxÖppnaKonto.Controls.Add(this.tbxKredit);
            this.gbxÖppnaKonto.Controls.Add(this.tbxRäntesats);
            this.gbxÖppnaKonto.Controls.Add(this.tbxPersonNr);
            this.gbxÖppnaKonto.Controls.Add(this.label4);
            this.gbxÖppnaKonto.Controls.Add(this.label3);
            this.gbxÖppnaKonto.Controls.Add(this.label2);
            this.gbxÖppnaKonto.Location = new System.Drawing.Point(218, 12);
            this.gbxÖppnaKonto.Name = "gbxÖppnaKonto";
            this.gbxÖppnaKonto.Size = new System.Drawing.Size(200, 129);
            this.gbxÖppnaKonto.TabIndex = 1;
            this.gbxÖppnaKonto.TabStop = false;
            this.gbxÖppnaKonto.Text = "Öppna konto";
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(119, 96);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrera.TabIndex = 6;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // tbxKredit
            // 
            this.tbxKredit.Location = new System.Drawing.Point(80, 70);
            this.tbxKredit.Name = "tbxKredit";
            this.tbxKredit.Size = new System.Drawing.Size(114, 20);
            this.tbxKredit.TabIndex = 5;
            // 
            // tbxRäntesats
            // 
            this.tbxRäntesats.Location = new System.Drawing.Point(80, 43);
            this.tbxRäntesats.Name = "tbxRäntesats";
            this.tbxRäntesats.Size = new System.Drawing.Size(114, 20);
            this.tbxRäntesats.TabIndex = 4;
            // 
            // tbxPersonNr
            // 
            this.tbxPersonNr.Location = new System.Drawing.Point(80, 16);
            this.tbxPersonNr.Name = "tbxPersonNr";
            this.tbxPersonNr.Size = new System.Drawing.Size(114, 20);
            this.tbxPersonNr.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kredit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Räntesats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PersonNr";
            // 
            // lbx1
            // 
            this.lbx1.FormattingEnabled = true;
            this.lbx1.Location = new System.Drawing.Point(424, 20);
            this.lbx1.Name = "lbx1";
            this.lbx1.Size = new System.Drawing.Size(350, 95);
            this.lbx1.TabIndex = 2;
            // 
            // btnUppÅrsränta
            // 
            this.btnUppÅrsränta.Location = new System.Drawing.Point(424, 118);
            this.btnUppÅrsränta.Name = "btnUppÅrsränta";
            this.btnUppÅrsränta.Size = new System.Drawing.Size(350, 23);
            this.btnUppÅrsränta.TabIndex = 3;
            this.btnUppÅrsränta.Text = "Uppdatera med årsränta";
            this.btnUppÅrsränta.UseVisualStyleBackColor = true;
            this.btnUppÅrsränta.Click += new System.EventHandler(this.btnUppÅrsränta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 159);
            this.Controls.Add(this.btnUppÅrsränta);
            this.Controls.Add(this.lbx1);
            this.Controls.Add(this.gbxÖppnaKonto);
            this.Controls.Add(this.gbxInsättningUttag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxInsättningUttag.ResumeLayout(false);
            this.gbxInsättningUttag.PerformLayout();
            this.gbxÖppnaKonto.ResumeLayout(false);
            this.gbxÖppnaKonto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInsättningUttag;
        private System.Windows.Forms.GroupBox gbxÖppnaKonto;
        private System.Windows.Forms.Button btnUttag;
        private System.Windows.Forms.Button btnInsättning;
        private System.Windows.Forms.TextBox tbxBelopp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.TextBox tbxKredit;
        private System.Windows.Forms.TextBox tbxRäntesats;
        private System.Windows.Forms.TextBox tbxPersonNr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbx1;
        private System.Windows.Forms.Button btnUppÅrsränta;
    }
}

