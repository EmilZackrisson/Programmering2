namespace Chat_Client
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
            this.tbxMeddelande = new System.Windows.Forms.TextBox();
            this.btnSkicka = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.tbxIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.btnLämna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxMeddelande
            // 
            this.tbxMeddelande.Location = new System.Drawing.Point(89, 245);
            this.tbxMeddelande.Name = "tbxMeddelande";
            this.tbxMeddelande.Size = new System.Drawing.Size(283, 20);
            this.tbxMeddelande.TabIndex = 0;
            // 
            // btnSkicka
            // 
            this.btnSkicka.Enabled = false;
            this.btnSkicka.Location = new System.Drawing.Point(12, 271);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(360, 23);
            this.btnSkicka.TabIndex = 1;
            this.btnSkicka.Text = "Skicka";
            this.btnSkicka.UseVisualStyleBackColor = true;
            this.btnSkicka.Click += new System.EventHandler(this.btnSkicka_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meddelande:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 199);
            this.listBox1.TabIndex = 3;
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(191, 12);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(75, 23);
            this.btnAnslut.TabIndex = 4;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click);
            // 
            // tbxIp
            // 
            this.tbxIp.Location = new System.Drawing.Point(85, 14);
            this.tbxIp.Name = "tbxIp";
            this.tbxIp.Size = new System.Drawing.Size(100, 20);
            this.tbxIp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server IP:";
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Red;
            this.pnStatus.Location = new System.Drawing.Point(353, 12);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(19, 20);
            this.pnStatus.TabIndex = 6;
            // 
            // btnLämna
            // 
            this.btnLämna.Enabled = false;
            this.btnLämna.Location = new System.Drawing.Point(272, 12);
            this.btnLämna.Name = "btnLämna";
            this.btnLämna.Size = new System.Drawing.Size(75, 23);
            this.btnLämna.TabIndex = 7;
            this.btnLämna.Text = "Lämna";
            this.btnLämna.UseVisualStyleBackColor = true;
            this.btnLämna.Click += new System.EventHandler(this.btnLämna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 313);
            this.Controls.Add(this.btnLämna);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.tbxIp);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSkicka);
            this.Controls.Add(this.tbxMeddelande);
            this.Name = "Form1";
            this.Text = "Chattklient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxMeddelande;
        private System.Windows.Forms.Button btnSkicka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.TextBox tbxIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Button btnLämna;
    }
}

