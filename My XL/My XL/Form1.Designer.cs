namespace My_XL
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateHeader = new System.Windows.Forms.Button();
            this.tbxUpdateHeader = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbRowSel = new System.Windows.Forms.RadioButton();
            this.rdbCellSel = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateCell = new System.Windows.Forms.Button();
            this.tbxUpdateCell = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rtxDebug = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateHeader);
            this.groupBox1.Controls.Add(this.tbxUpdateHeader);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update column header";
            // 
            // btnUpdateHeader
            // 
            this.btnUpdateHeader.Location = new System.Drawing.Point(319, 20);
            this.btnUpdateHeader.Name = "btnUpdateHeader";
            this.btnUpdateHeader.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateHeader.TabIndex = 1;
            this.btnUpdateHeader.Text = "Update";
            this.btnUpdateHeader.UseVisualStyleBackColor = true;
            this.btnUpdateHeader.Click += new System.EventHandler(this.btnUpdateHeader_Click);
            // 
            // tbxUpdateHeader
            // 
            this.tbxUpdateHeader.Location = new System.Drawing.Point(7, 20);
            this.tbxUpdateHeader.Name = "tbxUpdateHeader";
            this.tbxUpdateHeader.Size = new System.Drawing.Size(306, 20);
            this.tbxUpdateHeader.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbRowSel);
            this.groupBox2.Controls.Add(this.rdbCellSel);
            this.groupBox2.Location = new System.Drawing.Point(419, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 71);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection";
            // 
            // rdbRowSel
            // 
            this.rdbRowSel.AutoSize = true;
            this.rdbRowSel.Location = new System.Drawing.Point(7, 44);
            this.rdbRowSel.Name = "rdbRowSel";
            this.rdbRowSel.Size = new System.Drawing.Size(92, 17);
            this.rdbRowSel.TabIndex = 1;
            this.rdbRowSel.TabStop = true;
            this.rdbRowSel.Text = "Row selection";
            this.rdbRowSel.UseVisualStyleBackColor = true;
            this.rdbRowSel.CheckedChanged += new System.EventHandler(this.rdbRowSel_CheckedChanged);
            // 
            // rdbCellSel
            // 
            this.rdbCellSel.AutoSize = true;
            this.rdbCellSel.Location = new System.Drawing.Point(7, 20);
            this.rdbCellSel.Name = "rdbCellSel";
            this.rdbCellSel.Size = new System.Drawing.Size(87, 17);
            this.rdbCellSel.TabIndex = 0;
            this.rdbCellSel.TabStop = true;
            this.rdbCellSel.Text = "Cell selection";
            this.rdbCellSel.UseVisualStyleBackColor = true;
            this.rdbCellSel.CheckedChanged += new System.EventHandler(this.rdbCellSel_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add row";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdateCell);
            this.groupBox3.Controls.Add(this.tbxUpdateCell);
            this.groupBox3.Location = new System.Drawing.Point(13, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 56);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update cell text";
            // 
            // btnUpdateCell
            // 
            this.btnUpdateCell.Location = new System.Drawing.Point(319, 17);
            this.btnUpdateCell.Name = "btnUpdateCell";
            this.btnUpdateCell.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCell.TabIndex = 3;
            this.btnUpdateCell.Text = "Update";
            this.btnUpdateCell.UseVisualStyleBackColor = true;
            this.btnUpdateCell.Click += new System.EventHandler(this.btnUpdateCell_Click);
            // 
            // tbxUpdateCell
            // 
            this.tbxUpdateCell.Location = new System.Drawing.Point(7, 19);
            this.tbxUpdateCell.Name = "tbxUpdateCell";
            this.tbxUpdateCell.Size = new System.Drawing.Size(306, 20);
            this.tbxUpdateCell.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSsn,
            this.colGender,
            this.colAge});
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 308);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colSsn
            // 
            this.colSsn.HeaderText = "Social Security Number";
            this.colSsn.Name = "colSsn";
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Persons.csv";
            this.saveFileDialog1.Filter = "CSV-fil | *.csv";
            // 
            // rtxDebug
            // 
            this.rtxDebug.Location = new System.Drawing.Point(714, 43);
            this.rtxDebug.Name = "rtxDebug";
            this.rtxDebug.Size = new System.Drawing.Size(235, 179);
            this.rtxDebug.TabIndex = 8;
            this.rtxDebug.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "CSV-fil | *.csv";
            this.openFileDialog1.Title = "Öppna Person-fil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 478);
            this.Controls.Add(this.rtxDebug);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateHeader;
        private System.Windows.Forms.TextBox tbxUpdateHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbRowSel;
        private System.Windows.Forms.RadioButton rdbCellSel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateCell;
        private System.Windows.Forms.TextBox tbxUpdateCell;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rtxDebug;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

