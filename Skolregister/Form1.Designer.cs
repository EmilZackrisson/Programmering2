namespace Skolregister
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
            this.components = new System.ComponentModel.Container();
            this.dbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRegElev = new System.Windows.Forms.Button();
            this.tbxElevEfternamn = new System.Windows.Forms.TextBox();
            this.tbxElevFörnamn = new System.Windows.Forms.TextBox();
            this.tbxPersonnummer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRegKurs = new System.Windows.Forms.Button();
            this.tbxRegPoäng = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxRegKursnamn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxRegKurskod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRegBok = new System.Windows.Forms.Button();
            this.tbxRegBokÄmne = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxRegBokTitel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnNyttLån = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPersonNrLån = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxLåneDatum = new System.Windows.Forms.TextBox();
            this.tbxBokNrLån = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnKursvalReg = new System.Windows.Forms.Button();
            this.tbxKursPersonNr = new System.Windows.Forms.TextBox();
            this.cbxKurskod = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.btnUppdatera = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataVy = new System.Windows.Forms.DataGridView();
            this.PersonNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFörnamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEfternamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVy)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 338);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRegElev);
            this.tabPage1.Controls.Add(this.tbxElevEfternamn);
            this.tabPage1.Controls.Add(this.tbxElevFörnamn);
            this.tabPage1.Controls.Add(this.tbxPersonnummer);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(280, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Elever";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegElev
            // 
            this.btnRegElev.Location = new System.Drawing.Point(89, 101);
            this.btnRegElev.Name = "btnRegElev";
            this.btnRegElev.Size = new System.Drawing.Size(102, 23);
            this.btnRegElev.TabIndex = 3;
            this.btnRegElev.Text = "Registrera Elev";
            this.btnRegElev.UseVisualStyleBackColor = true;
            this.btnRegElev.Click += new System.EventHandler(this.btnRegElev_Click);
            // 
            // tbxElevEfternamn
            // 
            this.tbxElevEfternamn.Location = new System.Drawing.Point(89, 64);
            this.tbxElevEfternamn.Name = "tbxElevEfternamn";
            this.tbxElevEfternamn.Size = new System.Drawing.Size(150, 20);
            this.tbxElevEfternamn.TabIndex = 2;
            // 
            // tbxElevFörnamn
            // 
            this.tbxElevFörnamn.Location = new System.Drawing.Point(89, 38);
            this.tbxElevFörnamn.Name = "tbxElevFörnamn";
            this.tbxElevFörnamn.Size = new System.Drawing.Size(150, 20);
            this.tbxElevFörnamn.TabIndex = 1;
            // 
            // tbxPersonnummer
            // 
            this.tbxPersonnummer.Location = new System.Drawing.Point(89, 11);
            this.tbxPersonnummer.Name = "tbxPersonnummer";
            this.tbxPersonnummer.Size = new System.Drawing.Size(150, 20);
            this.tbxPersonnummer.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Efternamn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Förnamn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personnummer:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRegKurs);
            this.tabPage2.Controls.Add(this.tbxRegPoäng);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbxRegKursnamn);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbxRegKurskod);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(280, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kurser";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegKurs
            // 
            this.btnRegKurs.Location = new System.Drawing.Point(75, 125);
            this.btnRegKurs.Name = "btnRegKurs";
            this.btnRegKurs.Size = new System.Drawing.Size(100, 23);
            this.btnRegKurs.TabIndex = 2;
            this.btnRegKurs.Text = "Registrera ny kurs";
            this.btnRegKurs.UseVisualStyleBackColor = true;
            this.btnRegKurs.Click += new System.EventHandler(this.btnRegKurs_Click);
            // 
            // tbxRegPoäng
            // 
            this.tbxRegPoäng.Location = new System.Drawing.Point(75, 79);
            this.tbxRegPoäng.Name = "tbxRegPoäng";
            this.tbxRegPoäng.Size = new System.Drawing.Size(100, 20);
            this.tbxRegPoäng.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Poäng:";
            // 
            // tbxRegKursnamn
            // 
            this.tbxRegKursnamn.Location = new System.Drawing.Point(75, 53);
            this.tbxRegKursnamn.Name = "tbxRegKursnamn";
            this.tbxRegKursnamn.Size = new System.Drawing.Size(100, 20);
            this.tbxRegKursnamn.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kursnamn:";
            // 
            // tbxRegKurskod
            // 
            this.tbxRegKurskod.Location = new System.Drawing.Point(75, 27);
            this.tbxRegKurskod.Name = "tbxRegKurskod";
            this.tbxRegKurskod.Size = new System.Drawing.Size(100, 20);
            this.tbxRegKurskod.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kurskod:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRegBok);
            this.tabPage3.Controls.Add(this.tbxRegBokÄmne);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.tbxRegBokTitel);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(280, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Böcker";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRegBok
            // 
            this.btnRegBok.Location = new System.Drawing.Point(81, 99);
            this.btnRegBok.Name = "btnRegBok";
            this.btnRegBok.Size = new System.Drawing.Size(100, 23);
            this.btnRegBok.TabIndex = 2;
            this.btnRegBok.Text = "Registrera Bok";
            this.btnRegBok.UseVisualStyleBackColor = true;
            this.btnRegBok.Click += new System.EventHandler(this.btnRegBok_Click);
            // 
            // tbxRegBokÄmne
            // 
            this.tbxRegBokÄmne.Location = new System.Drawing.Point(81, 52);
            this.tbxRegBokÄmne.Name = "tbxRegBokÄmne";
            this.tbxRegBokÄmne.Size = new System.Drawing.Size(100, 20);
            this.tbxRegBokÄmne.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ämne:";
            // 
            // tbxRegBokTitel
            // 
            this.tbxRegBokTitel.Location = new System.Drawing.Point(81, 26);
            this.tbxRegBokTitel.Name = "tbxRegBokTitel";
            this.tbxRegBokTitel.Size = new System.Drawing.Size(100, 20);
            this.tbxRegBokTitel.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Titel:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnNyttLån);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.tbxPersonNrLån);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.tbxLåneDatum);
            this.tabPage4.Controls.Add(this.tbxBokNrLån);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(280, 312);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Boklån";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnNyttLån
            // 
            this.btnNyttLån.Location = new System.Drawing.Point(94, 109);
            this.btnNyttLån.Name = "btnNyttLån";
            this.btnNyttLån.Size = new System.Drawing.Size(90, 23);
            this.btnNyttLån.TabIndex = 2;
            this.btnNyttLån.Text = "Registrera Lån";
            this.btnNyttLån.UseVisualStyleBackColor = true;
            this.btnNyttLån.Click += new System.EventHandler(this.btnNyttLån_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Personnummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lånedatum:";
            // 
            // tbxPersonNrLån
            // 
            this.tbxPersonNrLån.Location = new System.Drawing.Point(94, 71);
            this.tbxPersonNrLån.Name = "tbxPersonNrLån";
            this.tbxPersonNrLån.Size = new System.Drawing.Size(100, 20);
            this.tbxPersonNrLån.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bok nummer:";
            // 
            // tbxLåneDatum
            // 
            this.tbxLåneDatum.Location = new System.Drawing.Point(94, 42);
            this.tbxLåneDatum.Name = "tbxLåneDatum";
            this.tbxLåneDatum.Size = new System.Drawing.Size(100, 20);
            this.tbxLåneDatum.TabIndex = 0;
            // 
            // tbxBokNrLån
            // 
            this.tbxBokNrLån.Location = new System.Drawing.Point(94, 16);
            this.tbxBokNrLån.Name = "tbxBokNrLån";
            this.tbxBokNrLån.Size = new System.Drawing.Size(100, 20);
            this.tbxBokNrLån.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnKursvalReg);
            this.tabPage5.Controls.Add(this.tbxKursPersonNr);
            this.tabPage5.Controls.Add(this.cbxKurskod);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(280, 312);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Kursval";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnKursvalReg
            // 
            this.btnKursvalReg.Location = new System.Drawing.Point(106, 84);
            this.btnKursvalReg.Name = "btnKursvalReg";
            this.btnKursvalReg.Size = new System.Drawing.Size(121, 23);
            this.btnKursvalReg.TabIndex = 3;
            this.btnKursvalReg.Text = "Resistrera kursval";
            this.btnKursvalReg.UseVisualStyleBackColor = true;
            this.btnKursvalReg.Click += new System.EventHandler(this.btnKursvalReg_Click);
            // 
            // tbxKursPersonNr
            // 
            this.tbxKursPersonNr.Location = new System.Drawing.Point(106, 41);
            this.tbxKursPersonNr.Name = "tbxKursPersonNr";
            this.tbxKursPersonNr.Size = new System.Drawing.Size(121, 20);
            this.tbxKursPersonNr.TabIndex = 2;
            // 
            // cbxKurskod
            // 
            this.cbxKurskod.FormattingEnabled = true;
            this.cbxKurskod.Location = new System.Drawing.Point(106, 13);
            this.cbxKurskod.Name = "cbxKurskod";
            this.cbxKurskod.Size = new System.Drawing.Size(121, 21);
            this.cbxKurskod.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Personnummer:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Kurskod:";
            // 
            // tbxFilter
            // 
            this.tbxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFilter.Location = new System.Drawing.Point(191, 8);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(100, 20);
            this.tbxFilter.TabIndex = 2;
            // 
            // cbxFilter
            // 
            this.cbxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Items.AddRange(new object[] {
            "Visa alla elever",
            "Visa alla böcker",
            "Visa alla kurser",
            "Visa lediga böcker",
            "Visa lånade böcker",
            "Visa kursgrupp"});
            this.cbxFilter.Location = new System.Drawing.Point(298, 8);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(121, 21);
            this.cbxFilter.TabIndex = 3;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // btnUppdatera
            // 
            this.btnUppdatera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUppdatera.Location = new System.Drawing.Point(425, 7);
            this.btnUppdatera.Name = "btnUppdatera";
            this.btnUppdatera.Size = new System.Drawing.Size(75, 23);
            this.btnUppdatera.TabIndex = 4;
            this.btnUppdatera.Text = "Uppdatera";
            this.btnUppdatera.UseVisualStyleBackColor = true;
            this.btnUppdatera.Click += new System.EventHandler(this.btnUppdatera_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(288, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 338);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataVy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 300);
            this.panel3.TabIndex = 6;
            // 
            // dataVy
            // 
            this.dataVy.AllowUserToAddRows = false;
            this.dataVy.AllowUserToDeleteRows = false;
            this.dataVy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonNr,
            this.colFörnamn,
            this.colEfternamn});
            this.dataVy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataVy.Location = new System.Drawing.Point(0, 0);
            this.dataVy.Name = "dataVy";
            this.dataVy.ReadOnly = true;
            this.dataVy.Size = new System.Drawing.Size(512, 300);
            this.dataVy.TabIndex = 0;
            // 
            // PersonNr
            // 
            this.PersonNr.HeaderText = "PersonNr";
            this.PersonNr.Name = "PersonNr";
            this.PersonNr.ReadOnly = true;
            // 
            // colFörnamn
            // 
            this.colFörnamn.HeaderText = "Förnamn";
            this.colFörnamn.Name = "colFörnamn";
            this.colFörnamn.ReadOnly = true;
            // 
            // colEfternamn
            // 
            this.colEfternamn.HeaderText = "Efternamn";
            this.colEfternamn.Name = "colEfternamn";
            this.colEfternamn.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxFilter);
            this.panel2.Controls.Add(this.tbxFilter);
            this.panel2.Controls.Add(this.btnUppdatera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 38);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataVy)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dbDataSetBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRegElev;
        private System.Windows.Forms.TextBox tbxElevEfternamn;
        private System.Windows.Forms.TextBox tbxElevFörnamn;
        private System.Windows.Forms.TextBox tbxPersonnummer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.Button btnUppdatera;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataVy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFörnamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEfternamn;
        private System.Windows.Forms.Button btnNyttLån;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPersonNrLån;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLåneDatum;
        private System.Windows.Forms.TextBox tbxBokNrLån;
        private System.Windows.Forms.Button btnRegBok;
        private System.Windows.Forms.TextBox tbxRegBokÄmne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxRegBokTitel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegKurs;
        private System.Windows.Forms.TextBox tbxRegPoäng;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxRegKursnamn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxRegKurskod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKursvalReg;
        private System.Windows.Forms.TextBox tbxKursPersonNr;
        private System.Windows.Forms.ComboBox cbxKurskod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

