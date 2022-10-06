namespace Övning_1._5_Fordonsregister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxRegNr = new System.Windows.Forms.TextBox();
            this.tbxMärke = new System.Windows.Forms.TextBox();
            this.tbxModell = new System.Windows.Forms.TextBox();
            this.cbxTyp = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.gbxVisa = new System.Windows.Forms.GroupBox();
            this.rbxMC = new System.Windows.Forms.RadioButton();
            this.rbxBilar = new System.Windows.Forms.RadioButton();
            this.rbxAlla = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSök = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSök = new System.Windows.Forms.TextBox();
            this.gbxVisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg-nr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Märke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Typ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Register";
            // 
            // tbxRegNr
            // 
            this.tbxRegNr.Location = new System.Drawing.Point(60, 112);
            this.tbxRegNr.Name = "tbxRegNr";
            this.tbxRegNr.Size = new System.Drawing.Size(100, 20);
            this.tbxRegNr.TabIndex = 6;
            // 
            // tbxMärke
            // 
            this.tbxMärke.Location = new System.Drawing.Point(60, 144);
            this.tbxMärke.Name = "tbxMärke";
            this.tbxMärke.Size = new System.Drawing.Size(100, 20);
            this.tbxMärke.TabIndex = 7;
            // 
            // tbxModell
            // 
            this.tbxModell.Location = new System.Drawing.Point(60, 175);
            this.tbxModell.Name = "tbxModell";
            this.tbxModell.Size = new System.Drawing.Size(100, 20);
            this.tbxModell.TabIndex = 8;
            // 
            // cbxTyp
            // 
            this.cbxTyp.FormattingEnabled = true;
            this.cbxTyp.Location = new System.Drawing.Point(60, 205);
            this.cbxTyp.Name = "cbxTyp";
            this.cbxTyp.Size = new System.Drawing.Size(100, 21);
            this.cbxTyp.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(323, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 147);
            this.listBox1.TabIndex = 10;
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(60, 246);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(100, 23);
            this.btnRegistrera.TabIndex = 11;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // gbxVisa
            // 
            this.gbxVisa.Controls.Add(this.rbxMC);
            this.gbxVisa.Controls.Add(this.rbxBilar);
            this.gbxVisa.Controls.Add(this.rbxAlla);
            this.gbxVisa.Location = new System.Drawing.Point(324, 180);
            this.gbxVisa.Name = "gbxVisa";
            this.gbxVisa.Size = new System.Drawing.Size(200, 100);
            this.gbxVisa.TabIndex = 12;
            this.gbxVisa.TabStop = false;
            this.gbxVisa.Text = "Visa";
            // 
            // rbxMC
            // 
            this.rbxMC.AutoSize = true;
            this.rbxMC.Location = new System.Drawing.Point(121, 45);
            this.rbxMC.Name = "rbxMC";
            this.rbxMC.Size = new System.Drawing.Size(41, 17);
            this.rbxMC.TabIndex = 2;
            this.rbxMC.TabStop = true;
            this.rbxMC.Text = "MC";
            this.rbxMC.UseVisualStyleBackColor = true;
            this.rbxMC.CheckedChanged += new System.EventHandler(this.rbxMC_CheckedChanged);
            // 
            // rbxBilar
            // 
            this.rbxBilar.AutoSize = true;
            this.rbxBilar.Location = new System.Drawing.Point(69, 45);
            this.rbxBilar.Name = "rbxBilar";
            this.rbxBilar.Size = new System.Drawing.Size(45, 17);
            this.rbxBilar.TabIndex = 1;
            this.rbxBilar.TabStop = true;
            this.rbxBilar.Text = "Bilar";
            this.rbxBilar.UseVisualStyleBackColor = true;
            this.rbxBilar.CheckedChanged += new System.EventHandler(this.rbxBilar_CheckedChanged);
            // 
            // rbxAlla
            // 
            this.rbxAlla.AutoSize = true;
            this.rbxAlla.Checked = true;
            this.rbxAlla.Location = new System.Drawing.Point(6, 45);
            this.rbxAlla.Name = "rbxAlla";
            this.rbxAlla.Size = new System.Drawing.Size(42, 17);
            this.rbxAlla.TabIndex = 0;
            this.rbxAlla.TabStop = true;
            this.rbxAlla.Text = "Alla";
            this.rbxAlla.UseVisualStyleBackColor = true;
            this.rbxAlla.CheckedChanged += new System.EventHandler(this.rbxAlla_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Övning_1._5_Fordonsregister.Properties.Resources.fin_bil;
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 84);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSök);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxSök);
            this.groupBox1.Location = new System.Drawing.Point(324, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 87);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök";
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(11, 51);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(183, 23);
            this.btnSök.TabIndex = 2;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sökord";
            // 
            // tbxSök
            // 
            this.tbxSök.Location = new System.Drawing.Point(69, 19);
            this.tbxSök.Name = "tbxSök";
            this.tbxSök.Size = new System.Drawing.Size(125, 20);
            this.tbxSök.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxVisa);
            this.Controls.Add(this.btnRegistrera);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbxTyp);
            this.Controls.Add(this.tbxModell);
            this.Controls.Add(this.tbxMärke);
            this.Controls.Add(this.tbxRegNr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Övning 1.5 Fordonsregister";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxVisa.ResumeLayout(false);
            this.gbxVisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRegNr;
        private System.Windows.Forms.TextBox tbxMärke;
        private System.Windows.Forms.TextBox tbxModell;
        private System.Windows.Forms.ComboBox cbxTyp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.GroupBox gbxVisa;
        private System.Windows.Forms.RadioButton rbxMC;
        private System.Windows.Forms.RadioButton rbxBilar;
        private System.Windows.Forms.RadioButton rbxAlla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxSök;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.Label label6;
    }
}

