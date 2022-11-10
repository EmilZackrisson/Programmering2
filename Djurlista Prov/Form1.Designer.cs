namespace Djurlista_Prov
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
            this.gbxRegHund = new System.Windows.Forms.GroupBox();
            this.tbxRegHundNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxRegHundRas = new System.Windows.Forms.TextBox();
            this.tbxRegHundId = new System.Windows.Forms.TextBox();
            this.btnRegHund = new System.Windows.Forms.Button();
            this.gbxRegKatt = new System.Windows.Forms.GroupBox();
            this.btnRegKatt = new System.Windows.Forms.Button();
            this.tbxRegKattÅlder = new System.Windows.Forms.TextBox();
            this.tbxRegKattNamn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvDjur = new System.Windows.Forms.ListView();
            this.rdbKatt = new System.Windows.Forms.RadioButton();
            this.rdbHund = new System.Windows.Forms.RadioButton();
            this.colNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colÅlder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOpererad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxRegKattOpererad = new System.Windows.Forms.CheckBox();
            this.gbxUppKatt = new System.Windows.Forms.GroupBox();
            this.cbxUppKattOpererad = new System.Windows.Forms.CheckBox();
            this.btnUppKatt = new System.Windows.Forms.Button();
            this.tbxUppKattÅlder = new System.Windows.Forms.TextBox();
            this.tbxUppKattNamn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxUppHund = new System.Windows.Forms.GroupBox();
            this.btnUppHund = new System.Windows.Forms.Button();
            this.tbxUppHundId = new System.Windows.Forms.TextBox();
            this.tbxUppHundRas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxUppHundNamn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxRegHund.SuspendLayout();
            this.gbxRegKatt.SuspendLayout();
            this.gbxUppKatt.SuspendLayout();
            this.gbxUppHund.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbHund);
            this.groupBox1.Controls.Add(this.rdbKatt);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vad vill du registrera?";
            // 
            // gbxRegHund
            // 
            this.gbxRegHund.Controls.Add(this.btnRegHund);
            this.gbxRegHund.Controls.Add(this.tbxRegHundId);
            this.gbxRegHund.Controls.Add(this.tbxRegHundRas);
            this.gbxRegHund.Controls.Add(this.label3);
            this.gbxRegHund.Controls.Add(this.tbxRegHundNamn);
            this.gbxRegHund.Controls.Add(this.label2);
            this.gbxRegHund.Controls.Add(this.label1);
            this.gbxRegHund.Location = new System.Drawing.Point(13, 66);
            this.gbxRegHund.Name = "gbxRegHund";
            this.gbxRegHund.Size = new System.Drawing.Size(216, 127);
            this.gbxRegHund.TabIndex = 1;
            this.gbxRegHund.TabStop = false;
            this.gbxRegHund.Text = "Hund";
            this.gbxRegHund.Visible = false;
            // 
            // tbxRegHundNamn
            // 
            this.tbxRegHundNamn.Location = new System.Drawing.Point(60, 19);
            this.tbxRegHundNamn.Name = "tbxRegHundNamn";
            this.tbxRegHundNamn.Size = new System.Drawing.Size(147, 20);
            this.tbxRegHundNamn.TabIndex = 0;
            this.tbxRegHundNamn.TextChanged += new System.EventHandler(this.tbxRegHundChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Namn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // tbxRegHundRas
            // 
            this.tbxRegHundRas.Location = new System.Drawing.Point(60, 41);
            this.tbxRegHundRas.Name = "tbxRegHundRas";
            this.tbxRegHundRas.Size = new System.Drawing.Size(147, 20);
            this.tbxRegHundRas.TabIndex = 5;
            this.tbxRegHundRas.TextChanged += new System.EventHandler(this.tbxRegHundChanged);
            // 
            // tbxRegHundId
            // 
            this.tbxRegHundId.Location = new System.Drawing.Point(60, 63);
            this.tbxRegHundId.Name = "tbxRegHundId";
            this.tbxRegHundId.Size = new System.Drawing.Size(147, 20);
            this.tbxRegHundId.TabIndex = 6;
            this.tbxRegHundId.TextChanged += new System.EventHandler(this.tbxRegHundChanged);
            // 
            // btnRegHund
            // 
            this.btnRegHund.Location = new System.Drawing.Point(132, 89);
            this.btnRegHund.Name = "btnRegHund";
            this.btnRegHund.Size = new System.Drawing.Size(75, 23);
            this.btnRegHund.TabIndex = 7;
            this.btnRegHund.Text = "Registrera";
            this.btnRegHund.UseVisualStyleBackColor = true;
            this.btnRegHund.Click += new System.EventHandler(this.btnRegHund_Click);
            // 
            // gbxRegKatt
            // 
            this.gbxRegKatt.Controls.Add(this.cbxRegKattOpererad);
            this.gbxRegKatt.Controls.Add(this.btnRegKatt);
            this.gbxRegKatt.Controls.Add(this.tbxRegKattÅlder);
            this.gbxRegKatt.Controls.Add(this.tbxRegKattNamn);
            this.gbxRegKatt.Controls.Add(this.label5);
            this.gbxRegKatt.Controls.Add(this.label6);
            this.gbxRegKatt.Location = new System.Drawing.Point(13, 66);
            this.gbxRegKatt.Name = "gbxRegKatt";
            this.gbxRegKatt.Size = new System.Drawing.Size(216, 127);
            this.gbxRegKatt.TabIndex = 8;
            this.gbxRegKatt.TabStop = false;
            this.gbxRegKatt.Text = "Katt";
            this.gbxRegKatt.Visible = false;
            // 
            // btnRegKatt
            // 
            this.btnRegKatt.Location = new System.Drawing.Point(138, 89);
            this.btnRegKatt.Name = "btnRegKatt";
            this.btnRegKatt.Size = new System.Drawing.Size(75, 23);
            this.btnRegKatt.TabIndex = 7;
            this.btnRegKatt.Text = "Registrera";
            this.btnRegKatt.UseVisualStyleBackColor = true;
            this.btnRegKatt.Click += new System.EventHandler(this.btnRegKatt_Click);
            // 
            // tbxRegKattÅlder
            // 
            this.tbxRegKattÅlder.Location = new System.Drawing.Point(66, 41);
            this.tbxRegKattÅlder.Name = "tbxRegKattÅlder";
            this.tbxRegKattÅlder.Size = new System.Drawing.Size(147, 20);
            this.tbxRegKattÅlder.TabIndex = 5;
            this.tbxRegKattÅlder.TextChanged += new System.EventHandler(this.tbxRegKattNamn_TextChanged);
            // 
            // tbxRegKattNamn
            // 
            this.tbxRegKattNamn.Location = new System.Drawing.Point(66, 19);
            this.tbxRegKattNamn.Name = "tbxRegKattNamn";
            this.tbxRegKattNamn.Size = new System.Drawing.Size(147, 20);
            this.tbxRegKattNamn.TabIndex = 0;
            this.tbxRegKattNamn.TextChanged += new System.EventHandler(this.tbxRegKattNamn_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ålder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Namn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 42);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mina djur";
            // 
            // lvDjur
            // 
            this.lvDjur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNamn,
            this.colRas,
            this.colId,
            this.colÅlder,
            this.colOpererad});
            this.lvDjur.GridLines = true;
            this.lvDjur.HideSelection = false;
            this.lvDjur.Location = new System.Drawing.Point(244, 66);
            this.lvDjur.MultiSelect = false;
            this.lvDjur.Name = "lvDjur";
            this.lvDjur.Size = new System.Drawing.Size(544, 372);
            this.lvDjur.TabIndex = 10;
            this.lvDjur.UseCompatibleStateImageBehavior = false;
            this.lvDjur.SelectedIndexChanged += new System.EventHandler(this.lvDjur_SelectedIndexChanged);
            // 
            // rdbKatt
            // 
            this.rdbKatt.AutoSize = true;
            this.rdbKatt.Location = new System.Drawing.Point(44, 19);
            this.rdbKatt.Name = "rdbKatt";
            this.rdbKatt.Size = new System.Drawing.Size(44, 17);
            this.rdbKatt.TabIndex = 0;
            this.rdbKatt.TabStop = true;
            this.rdbKatt.Text = "Katt";
            this.rdbKatt.UseVisualStyleBackColor = true;
            this.rdbKatt.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // rdbHund
            // 
            this.rdbHund.AutoSize = true;
            this.rdbHund.Location = new System.Drawing.Point(94, 19);
            this.rdbHund.Name = "rdbHund";
            this.rdbHund.Size = new System.Drawing.Size(51, 17);
            this.rdbHund.TabIndex = 1;
            this.rdbHund.TabStop = true;
            this.rdbHund.Text = "Hund";
            this.rdbHund.UseVisualStyleBackColor = true;
            this.rdbHund.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // colNamn
            // 
            this.colNamn.Text = "Namn";
            // 
            // colRas
            // 
            this.colRas.Text = "Ras";
            // 
            // colId
            // 
            this.colId.Text = "ID";
            // 
            // colÅlder
            // 
            this.colÅlder.Text = "Ålder";
            // 
            // colOpererad
            // 
            this.colOpererad.Text = "Opererad";
            // 
            // cbxRegKattOpererad
            // 
            this.cbxRegKattOpererad.AutoSize = true;
            this.cbxRegKattOpererad.Location = new System.Drawing.Point(66, 67);
            this.cbxRegKattOpererad.Name = "cbxRegKattOpererad";
            this.cbxRegKattOpererad.Size = new System.Drawing.Size(70, 17);
            this.cbxRegKattOpererad.TabIndex = 8;
            this.cbxRegKattOpererad.Text = "Opererad";
            this.cbxRegKattOpererad.UseVisualStyleBackColor = true;
            // 
            // gbxUppKatt
            // 
            this.gbxUppKatt.Controls.Add(this.cbxUppKattOpererad);
            this.gbxUppKatt.Controls.Add(this.btnUppKatt);
            this.gbxUppKatt.Controls.Add(this.tbxUppKattÅlder);
            this.gbxUppKatt.Controls.Add(this.tbxUppKattNamn);
            this.gbxUppKatt.Controls.Add(this.label4);
            this.gbxUppKatt.Controls.Add(this.label8);
            this.gbxUppKatt.Location = new System.Drawing.Point(13, 199);
            this.gbxUppKatt.Name = "gbxUppKatt";
            this.gbxUppKatt.Size = new System.Drawing.Size(216, 127);
            this.gbxUppKatt.TabIndex = 9;
            this.gbxUppKatt.TabStop = false;
            this.gbxUppKatt.Text = "Uppdatera katt";
            this.gbxUppKatt.Visible = false;
            // 
            // cbxUppKattOpererad
            // 
            this.cbxUppKattOpererad.AutoSize = true;
            this.cbxUppKattOpererad.Location = new System.Drawing.Point(66, 67);
            this.cbxUppKattOpererad.Name = "cbxUppKattOpererad";
            this.cbxUppKattOpererad.Size = new System.Drawing.Size(70, 17);
            this.cbxUppKattOpererad.TabIndex = 8;
            this.cbxUppKattOpererad.Text = "Opererad";
            this.cbxUppKattOpererad.UseVisualStyleBackColor = true;
            // 
            // btnUppKatt
            // 
            this.btnUppKatt.Location = new System.Drawing.Point(138, 89);
            this.btnUppKatt.Name = "btnUppKatt";
            this.btnUppKatt.Size = new System.Drawing.Size(75, 23);
            this.btnUppKatt.TabIndex = 7;
            this.btnUppKatt.Text = "Uppdatera";
            this.btnUppKatt.UseVisualStyleBackColor = true;
            this.btnUppKatt.Click += new System.EventHandler(this.btnUppKatt_Click);
            // 
            // tbxUppKattÅlder
            // 
            this.tbxUppKattÅlder.Location = new System.Drawing.Point(66, 41);
            this.tbxUppKattÅlder.Name = "tbxUppKattÅlder";
            this.tbxUppKattÅlder.Size = new System.Drawing.Size(147, 20);
            this.tbxUppKattÅlder.TabIndex = 5;
            // 
            // tbxUppKattNamn
            // 
            this.tbxUppKattNamn.Location = new System.Drawing.Point(66, 19);
            this.tbxUppKattNamn.Name = "tbxUppKattNamn";
            this.tbxUppKattNamn.Size = new System.Drawing.Size(147, 20);
            this.tbxUppKattNamn.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ålder:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Namn:";
            // 
            // gbxUppHund
            // 
            this.gbxUppHund.Controls.Add(this.btnUppHund);
            this.gbxUppHund.Controls.Add(this.tbxUppHundId);
            this.gbxUppHund.Controls.Add(this.tbxUppHundRas);
            this.gbxUppHund.Controls.Add(this.label11);
            this.gbxUppHund.Controls.Add(this.tbxUppHundNamn);
            this.gbxUppHund.Controls.Add(this.label12);
            this.gbxUppHund.Controls.Add(this.label13);
            this.gbxUppHund.Location = new System.Drawing.Point(13, 199);
            this.gbxUppHund.Name = "gbxUppHund";
            this.gbxUppHund.Size = new System.Drawing.Size(216, 127);
            this.gbxUppHund.TabIndex = 9;
            this.gbxUppHund.TabStop = false;
            this.gbxUppHund.Text = "Uppdatera Hund";
            this.gbxUppHund.Visible = false;
            // 
            // btnUppHund
            // 
            this.btnUppHund.Location = new System.Drawing.Point(132, 89);
            this.btnUppHund.Name = "btnUppHund";
            this.btnUppHund.Size = new System.Drawing.Size(75, 23);
            this.btnUppHund.TabIndex = 7;
            this.btnUppHund.Text = "Uppdatera";
            this.btnUppHund.UseVisualStyleBackColor = true;
            this.btnUppHund.Click += new System.EventHandler(this.btnUppHund_Click);
            // 
            // tbxUppHundId
            // 
            this.tbxUppHundId.Location = new System.Drawing.Point(60, 63);
            this.tbxUppHundId.Name = "tbxUppHundId";
            this.tbxUppHundId.Size = new System.Drawing.Size(147, 20);
            this.tbxUppHundId.TabIndex = 6;
            // 
            // tbxUppHundRas
            // 
            this.tbxUppHundRas.Location = new System.Drawing.Point(60, 41);
            this.tbxUppHundRas.Name = "tbxUppHundRas";
            this.tbxUppHundRas.Size = new System.Drawing.Size(147, 20);
            this.tbxUppHundRas.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "ID:";
            // 
            // tbxUppHundNamn
            // 
            this.tbxUppHundNamn.Location = new System.Drawing.Point(60, 19);
            this.tbxUppHundNamn.Name = "tbxUppHundNamn";
            this.tbxUppHundNamn.Size = new System.Drawing.Size(147, 20);
            this.tbxUppHundNamn.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ras:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Namn:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.gbxUppHund);
            this.Controls.Add(this.gbxUppKatt);
            this.Controls.Add(this.lvDjur);
            this.Controls.Add(this.gbxRegKatt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbxRegHund);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxRegHund.ResumeLayout(false);
            this.gbxRegHund.PerformLayout();
            this.gbxRegKatt.ResumeLayout(false);
            this.gbxRegKatt.PerformLayout();
            this.gbxUppKatt.ResumeLayout(false);
            this.gbxUppKatt.PerformLayout();
            this.gbxUppHund.ResumeLayout(false);
            this.gbxUppHund.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxRegHund;
        private System.Windows.Forms.Button btnRegHund;
        private System.Windows.Forms.TextBox tbxRegHundId;
        private System.Windows.Forms.TextBox tbxRegHundRas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxRegHundNamn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxRegKatt;
        private System.Windows.Forms.Button btnRegKatt;
        private System.Windows.Forms.TextBox tbxRegKattÅlder;
        private System.Windows.Forms.TextBox tbxRegKattNamn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvDjur;
        private System.Windows.Forms.RadioButton rdbKatt;
        private System.Windows.Forms.RadioButton rdbHund;
        private System.Windows.Forms.ColumnHeader colNamn;
        private System.Windows.Forms.ColumnHeader colRas;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colÅlder;
        private System.Windows.Forms.ColumnHeader colOpererad;
        private System.Windows.Forms.CheckBox cbxRegKattOpererad;
        private System.Windows.Forms.GroupBox gbxUppKatt;
        private System.Windows.Forms.CheckBox cbxUppKattOpererad;
        private System.Windows.Forms.Button btnUppKatt;
        private System.Windows.Forms.TextBox tbxUppKattÅlder;
        private System.Windows.Forms.TextBox tbxUppKattNamn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxUppHund;
        private System.Windows.Forms.Button btnUppHund;
        private System.Windows.Forms.TextBox tbxUppHundId;
        private System.Windows.Forms.TextBox tbxUppHundRas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxUppHundNamn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

