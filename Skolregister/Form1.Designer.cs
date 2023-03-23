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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.btnUppdatera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dbDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(306, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(482, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbDataSetBindingSource
            // 
            this.dbDataSetBindingSource.Position = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 310);
            this.tabControl1.TabIndex = 1;
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
            this.tabPage1.Size = new System.Drawing.Size(280, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Elever";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegElev
            // 
            this.btnRegElev.Location = new System.Drawing.Point(89, 101);
            this.btnRegElev.Name = "btnRegElev";
            this.btnRegElev.Size = new System.Drawing.Size(102, 23);
            this.btnRegElev.TabIndex = 2;
            this.btnRegElev.Text = "Registrera Elev";
            this.btnRegElev.UseVisualStyleBackColor = true;
            this.btnRegElev.Click += new System.EventHandler(this.btnRegElev_Click);
            // 
            // tbxElevEfternamn
            // 
            this.tbxElevEfternamn.Location = new System.Drawing.Point(89, 64);
            this.tbxElevEfternamn.Name = "tbxElevEfternamn";
            this.tbxElevEfternamn.Size = new System.Drawing.Size(150, 20);
            this.tbxElevEfternamn.TabIndex = 1;
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
            this.tbxPersonnummer.TabIndex = 1;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(280, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kurser";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(280, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Böcker";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(280, 284);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Boklån";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(280, 284);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Kursval";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(404, 8);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(100, 20);
            this.tbxFilter.TabIndex = 2;
            // 
            // cbxFilter
            // 
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Items.AddRange(new object[] {
            "Visa alla elever",
            "Visa alla böcker",
            "Visa alla kurser",
            "Visa lediga böcker",
            "Visa lånade böcker",
            "Visa kursgrupp"});
            this.cbxFilter.Location = new System.Drawing.Point(511, 7);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(121, 21);
            this.cbxFilter.TabIndex = 3;
            // 
            // btnUppdatera
            // 
            this.btnUppdatera.Location = new System.Drawing.Point(638, 8);
            this.btnUppdatera.Name = "btnUppdatera";
            this.btnUppdatera.Size = new System.Drawing.Size(75, 23);
            this.btnUppdatera.TabIndex = 4;
            this.btnUppdatera.Text = "Uppdatera";
            this.btnUppdatera.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.btnUppdatera);
            this.Controls.Add(this.cbxFilter);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}

