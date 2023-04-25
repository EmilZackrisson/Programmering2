namespace Databas_med_kod
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Förnamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpElev = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxBokÄmne = new System.Windows.Forms.TextBox();
            this.tbxBokTitel = new System.Windows.Forms.TextBox();
            this.btnBokReg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxBokFörfattare = new System.Windows.Forms.TextBox();
            this.tpLånaBok = new System.Windows.Forms.TabPage();
            this.tbxBoklånPersonNr = new System.Windows.Forms.TextBox();
            this.tbxBoklånBokNr = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpElev.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tpLånaBok.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lägg till elev";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personNr,
            this.Förnamn,
            this.efternamn});
            this.dataGridView1.Location = new System.Drawing.Point(391, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 226);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // personNr
            // 
            this.personNr.HeaderText = "PersonNr";
            this.personNr.Name = "personNr";
            this.personNr.ReadOnly = true;
            // 
            // Förnamn
            // 
            this.Förnamn.HeaderText = "Förnamn";
            this.Förnamn.Name = "Förnamn";
            this.Förnamn.ReadOnly = true;
            // 
            // efternamn
            // 
            this.efternamn.HeaderText = "Efternamn";
            this.efternamn.Name = "efternamn";
            this.efternamn.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpElev);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tpLånaBok);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 252);
            this.tabControl1.TabIndex = 5;
            // 
            // tpElev
            // 
            this.tpElev.Controls.Add(this.label3);
            this.tpElev.Controls.Add(this.label2);
            this.tpElev.Controls.Add(this.label1);
            this.tpElev.Controls.Add(this.textBox3);
            this.tpElev.Controls.Add(this.textBox1);
            this.tpElev.Controls.Add(this.textBox2);
            this.tpElev.Controls.Add(this.button1);
            this.tpElev.Location = new System.Drawing.Point(4, 22);
            this.tpElev.Name = "tpElev";
            this.tpElev.Padding = new System.Windows.Forms.Padding(3);
            this.tpElev.Size = new System.Drawing.Size(365, 226);
            this.tpElev.TabIndex = 0;
            this.tpElev.Text = "Elev";
            this.tpElev.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Efternamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Förnamn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PersonNr";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxBokFörfattare);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnBokReg);
            this.tabPage2.Controls.Add(this.tbxBokÄmne);
            this.tabPage2.Controls.Add(this.tbxBokTitel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(365, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reg Bok";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxBokÄmne
            // 
            this.tbxBokÄmne.Location = new System.Drawing.Point(71, 63);
            this.tbxBokÄmne.Name = "tbxBokÄmne";
            this.tbxBokÄmne.Size = new System.Drawing.Size(100, 20);
            this.tbxBokÄmne.TabIndex = 1;
            // 
            // tbxBokTitel
            // 
            this.tbxBokTitel.Location = new System.Drawing.Point(71, 27);
            this.tbxBokTitel.Name = "tbxBokTitel";
            this.tbxBokTitel.Size = new System.Drawing.Size(100, 20);
            this.tbxBokTitel.TabIndex = 0;
            // 
            // btnBokReg
            // 
            this.btnBokReg.Location = new System.Drawing.Point(55, 132);
            this.btnBokReg.Name = "btnBokReg";
            this.btnBokReg.Size = new System.Drawing.Size(75, 23);
            this.btnBokReg.TabIndex = 2;
            this.btnBokReg.Text = "Reg Bok";
            this.btnBokReg.UseVisualStyleBackColor = true;
            this.btnBokReg.Click += new System.EventHandler(this.btnBokReg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Titel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ämne";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Författare";
            // 
            // tbxBokFörfattare
            // 
            this.tbxBokFörfattare.Location = new System.Drawing.Point(71, 96);
            this.tbxBokFörfattare.Name = "tbxBokFörfattare";
            this.tbxBokFörfattare.Size = new System.Drawing.Size(100, 20);
            this.tbxBokFörfattare.TabIndex = 6;
            // 
            // tpLånaBok
            // 
            this.tpLånaBok.Controls.Add(this.dateTimePicker1);
            this.tpLånaBok.Controls.Add(this.button2);
            this.tpLånaBok.Controls.Add(this.tbxBoklånBokNr);
            this.tpLånaBok.Controls.Add(this.tbxBoklånPersonNr);
            this.tpLånaBok.Location = new System.Drawing.Point(4, 22);
            this.tpLånaBok.Name = "tpLånaBok";
            this.tpLånaBok.Padding = new System.Windows.Forms.Padding(3);
            this.tpLånaBok.Size = new System.Drawing.Size(365, 226);
            this.tpLånaBok.TabIndex = 2;
            this.tpLånaBok.Text = "Låna Bok";
            this.tpLånaBok.UseVisualStyleBackColor = true;
            // 
            // tbxBoklånPersonNr
            // 
            this.tbxBoklånPersonNr.Location = new System.Drawing.Point(115, 89);
            this.tbxBoklånPersonNr.Name = "tbxBoklånPersonNr";
            this.tbxBoklånPersonNr.Size = new System.Drawing.Size(100, 20);
            this.tbxBoklånPersonNr.TabIndex = 1;
            // 
            // tbxBoklånBokNr
            // 
            this.tbxBoklånBokNr.Location = new System.Drawing.Point(115, 55);
            this.tbxBoklånBokNr.Name = "tbxBoklånBokNr";
            this.tbxBoklånBokNr.Size = new System.Drawing.Size(100, 20);
            this.tbxBoklånBokNr.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 279);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpElev.ResumeLayout(false);
            this.tpElev.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tpLånaBok.ResumeLayout(false);
            this.tpLånaBok.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Förnamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternamn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpElev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxBokÄmne;
        private System.Windows.Forms.TextBox tbxBokTitel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBokReg;
        private System.Windows.Forms.TextBox tbxBokFörfattare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tpLånaBok;
        private System.Windows.Forms.TextBox tbxBoklånBokNr;
        private System.Windows.Forms.TextBox tbxBoklånPersonNr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

