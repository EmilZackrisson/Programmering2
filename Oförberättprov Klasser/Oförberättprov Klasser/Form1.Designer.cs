namespace Oförberättprov_Klasser
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
            this.btnReg = new System.Windows.Forms.Button();
            this.btnRensaReg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbBeboeligNej = new System.Windows.Forms.RadioButton();
            this.rdbBeboeligJa = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxRegRadie = new System.Windows.Forms.TextBox();
            this.tbxRegVolym = new System.Windows.Forms.TextBox();
            this.tbxRegNamn = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUppdatera = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbBeboeligUppdateraNej = new System.Windows.Forms.RadioButton();
            this.rdbBeboeligUppdateraJa = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxUppdateraRadie = new System.Windows.Forms.TextBox();
            this.tbxUppdateraVolym = new System.Windows.Forms.TextBox();
            this.tbxUppdateraNamn = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRemoveSel = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnKopiera = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Controls.Add(this.btnRensaReg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rdbBeboeligNej);
            this.groupBox1.Controls.Add(this.rdbBeboeligJa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxRegRadie);
            this.groupBox1.Controls.Add(this.tbxRegVolym);
            this.groupBox1.Controls.Add(this.tbxRegNamn);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrera planet";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(65, 133);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(99, 23);
            this.btnReg.TabIndex = 10;
            this.btnReg.Text = "Registrera";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnRensaReg
            // 
            this.btnRensaReg.Location = new System.Drawing.Point(6, 133);
            this.btnRensaReg.Name = "btnRensaReg";
            this.btnRensaReg.Size = new System.Drawing.Size(52, 23);
            this.btnRensaReg.TabIndex = 9;
            this.btnRensaReg.Text = "Rensa";
            this.btnRensaReg.UseVisualStyleBackColor = true;
            this.btnRensaReg.Click += new System.EventHandler(this.btnRensaReg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Beboelig zon";
            // 
            // rdbBeboeligNej
            // 
            this.rdbBeboeligNej.AutoSize = true;
            this.rdbBeboeligNej.Location = new System.Drawing.Point(123, 110);
            this.rdbBeboeligNej.Name = "rdbBeboeligNej";
            this.rdbBeboeligNej.Size = new System.Drawing.Size(41, 17);
            this.rdbBeboeligNej.TabIndex = 7;
            this.rdbBeboeligNej.TabStop = true;
            this.rdbBeboeligNej.Text = "Nej";
            this.rdbBeboeligNej.UseVisualStyleBackColor = true;
            this.rdbBeboeligNej.CheckedChanged += new System.EventHandler(this.rdbBeboeligNej_CheckedChanged);
            // 
            // rdbBeboeligJa
            // 
            this.rdbBeboeligJa.AutoSize = true;
            this.rdbBeboeligJa.Location = new System.Drawing.Point(81, 110);
            this.rdbBeboeligJa.Name = "rdbBeboeligJa";
            this.rdbBeboeligJa.Size = new System.Drawing.Size(36, 17);
            this.rdbBeboeligJa.TabIndex = 6;
            this.rdbBeboeligJa.TabStop = true;
            this.rdbBeboeligJa.Text = "Ja";
            this.rdbBeboeligJa.UseVisualStyleBackColor = true;
            this.rdbBeboeligJa.CheckedChanged += new System.EventHandler(this.rdbBeboeligJa_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Radie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Volym";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Namn";
            // 
            // tbxRegRadie
            // 
            this.tbxRegRadie.Location = new System.Drawing.Point(64, 73);
            this.tbxRegRadie.Name = "tbxRegRadie";
            this.tbxRegRadie.Size = new System.Drawing.Size(100, 20);
            this.tbxRegRadie.TabIndex = 2;
            this.tbxRegRadie.TextChanged += new System.EventHandler(this.tbxRegRadie_TextChanged);
            // 
            // tbxRegVolym
            // 
            this.tbxRegVolym.Location = new System.Drawing.Point(64, 47);
            this.tbxRegVolym.Name = "tbxRegVolym";
            this.tbxRegVolym.Size = new System.Drawing.Size(100, 20);
            this.tbxRegVolym.TabIndex = 1;
            this.tbxRegVolym.TextChanged += new System.EventHandler(this.tbxRegVolym_TextChanged);
            // 
            // tbxRegNamn
            // 
            this.tbxRegNamn.Location = new System.Drawing.Point(64, 21);
            this.tbxRegNamn.Name = "tbxRegNamn";
            this.tbxRegNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxRegNamn.TabIndex = 0;
            this.tbxRegNamn.TextChanged += new System.EventHandler(this.tbxRegNamn_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUppdatera);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rdbBeboeligUppdateraNej);
            this.groupBox2.Controls.Add(this.rdbBeboeligUppdateraJa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxUppdateraRadie);
            this.groupBox2.Controls.Add(this.tbxUppdateraVolym);
            this.groupBox2.Controls.Add(this.tbxUppdateraNamn);
            this.groupBox2.Location = new System.Drawing.Point(13, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 166);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uppdatera planet";
            // 
            // btnUppdatera
            // 
            this.btnUppdatera.Location = new System.Drawing.Point(65, 133);
            this.btnUppdatera.Name = "btnUppdatera";
            this.btnUppdatera.Size = new System.Drawing.Size(99, 23);
            this.btnUppdatera.TabIndex = 10;
            this.btnUppdatera.Text = "Uppdatera";
            this.btnUppdatera.UseVisualStyleBackColor = true;
            this.btnUppdatera.Click += new System.EventHandler(this.btnUppdatera_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Beboelig zon";
            // 
            // rdbBeboeligUppdateraNej
            // 
            this.rdbBeboeligUppdateraNej.AutoSize = true;
            this.rdbBeboeligUppdateraNej.Location = new System.Drawing.Point(123, 110);
            this.rdbBeboeligUppdateraNej.Name = "rdbBeboeligUppdateraNej";
            this.rdbBeboeligUppdateraNej.Size = new System.Drawing.Size(41, 17);
            this.rdbBeboeligUppdateraNej.TabIndex = 7;
            this.rdbBeboeligUppdateraNej.TabStop = true;
            this.rdbBeboeligUppdateraNej.Text = "Nej";
            this.rdbBeboeligUppdateraNej.UseVisualStyleBackColor = true;
            this.rdbBeboeligUppdateraNej.CheckedChanged += new System.EventHandler(this.rdbBeboeligUppdateraNej_CheckedChanged);
            // 
            // rdbBeboeligUppdateraJa
            // 
            this.rdbBeboeligUppdateraJa.AutoSize = true;
            this.rdbBeboeligUppdateraJa.Location = new System.Drawing.Point(81, 110);
            this.rdbBeboeligUppdateraJa.Name = "rdbBeboeligUppdateraJa";
            this.rdbBeboeligUppdateraJa.Size = new System.Drawing.Size(36, 17);
            this.rdbBeboeligUppdateraJa.TabIndex = 6;
            this.rdbBeboeligUppdateraJa.TabStop = true;
            this.rdbBeboeligUppdateraJa.Text = "Ja";
            this.rdbBeboeligUppdateraJa.UseVisualStyleBackColor = true;
            this.rdbBeboeligUppdateraJa.CheckedChanged += new System.EventHandler(this.rdbBeboeligUppdateraJa_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Radie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Volym";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Namn";
            // 
            // tbxUppdateraRadie
            // 
            this.tbxUppdateraRadie.Location = new System.Drawing.Point(64, 73);
            this.tbxUppdateraRadie.Name = "tbxUppdateraRadie";
            this.tbxUppdateraRadie.Size = new System.Drawing.Size(100, 20);
            this.tbxUppdateraRadie.TabIndex = 2;
            this.tbxUppdateraRadie.TextChanged += new System.EventHandler(this.tbxUppdateraRadie_TextChanged);
            // 
            // tbxUppdateraVolym
            // 
            this.tbxUppdateraVolym.Location = new System.Drawing.Point(64, 47);
            this.tbxUppdateraVolym.Name = "tbxUppdateraVolym";
            this.tbxUppdateraVolym.Size = new System.Drawing.Size(100, 20);
            this.tbxUppdateraVolym.TabIndex = 1;
            this.tbxUppdateraVolym.TextChanged += new System.EventHandler(this.tbxUppdateraVolym_TextChanged);
            // 
            // tbxUppdateraNamn
            // 
            this.tbxUppdateraNamn.Location = new System.Drawing.Point(64, 21);
            this.tbxUppdateraNamn.Name = "tbxUppdateraNamn";
            this.tbxUppdateraNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxUppdateraNamn.TabIndex = 0;
            this.tbxUppdateraNamn.TextChanged += new System.EventHandler(this.tbxUppdateraNamn_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(192, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(557, 342);
            this.listBox1.TabIndex = 12;
            // 
            // btnRemoveSel
            // 
            this.btnRemoveSel.Location = new System.Drawing.Point(375, 361);
            this.btnRemoveSel.Name = "btnRemoveSel";
            this.btnRemoveSel.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveSel.TabIndex = 13;
            this.btnRemoveSel.Text = "Ta bort markerad";
            this.btnRemoveSel.UseVisualStyleBackColor = true;
            this.btnRemoveSel.Click += new System.EventHandler(this.btnRemoveSel_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(490, 361);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 14;
            this.btnRemoveAll.Text = "Ta bort alla";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(256, 365);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Visa bara beboliga";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnKopiera
            // 
            this.btnKopiera.Location = new System.Drawing.Point(571, 361);
            this.btnKopiera.Name = "btnKopiera";
            this.btnKopiera.Size = new System.Drawing.Size(96, 23);
            this.btnKopiera.TabIndex = 16;
            this.btnKopiera.Text = "Kopiera planet";
            this.btnKopiera.UseVisualStyleBackColor = true;
            this.btnKopiera.Click += new System.EventHandler(this.btnKopiera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 393);
            this.Controls.Add(this.btnKopiera);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveSel);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnRensaReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbBeboeligNej;
        private System.Windows.Forms.RadioButton rdbBeboeligJa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxRegRadie;
        private System.Windows.Forms.TextBox tbxRegVolym;
        private System.Windows.Forms.TextBox tbxRegNamn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUppdatera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbBeboeligUppdateraNej;
        private System.Windows.Forms.RadioButton rdbBeboeligUppdateraJa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxUppdateraRadie;
        private System.Windows.Forms.TextBox tbxUppdateraVolym;
        private System.Windows.Forms.TextBox tbxUppdateraNamn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRemoveSel;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnKopiera;
    }
}

