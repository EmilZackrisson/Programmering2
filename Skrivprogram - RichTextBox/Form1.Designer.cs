namespace Skrivprogram___RichTextBox
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
            this.btnFont = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.rdbHöger = new System.Windows.Forms.RadioButton();
            this.rdbCenter = new System.Windows.Forms.RadioButton();
            this.rdbVänster = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inställningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ändraIkonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vänsterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mittenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.högerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(12, 62);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "Teckensnitt";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 92);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(775, 395);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.Location = new System.Drawing.Point(328, 62);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(25, 24);
            this.panelColor.TabIndex = 5;
            this.panelColor.Click += new System.EventHandler(this.färgväljare);
            // 
            // rdbHöger
            // 
            this.rdbHöger.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbHöger.AutoSize = true;
            this.rdbHöger.Image = global::Skrivprogram___RichTextBox.Properties.Resources.right;
            this.rdbHöger.Location = new System.Drawing.Point(197, 58);
            this.rdbHöger.Name = "rdbHöger";
            this.rdbHöger.Size = new System.Drawing.Size(31, 31);
            this.rdbHöger.TabIndex = 3;
            this.rdbHöger.TabStop = true;
            this.rdbHöger.UseVisualStyleBackColor = true;
            this.rdbHöger.CheckedChanged += new System.EventHandler(this.rdbHöger_CheckedChanged);
            // 
            // rdbCenter
            // 
            this.rdbCenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbCenter.AutoSize = true;
            this.rdbCenter.Image = global::Skrivprogram___RichTextBox.Properties.Resources.align_center;
            this.rdbCenter.Location = new System.Drawing.Point(160, 58);
            this.rdbCenter.Name = "rdbCenter";
            this.rdbCenter.Size = new System.Drawing.Size(31, 31);
            this.rdbCenter.TabIndex = 2;
            this.rdbCenter.TabStop = true;
            this.rdbCenter.UseVisualStyleBackColor = true;
            this.rdbCenter.CheckedChanged += new System.EventHandler(this.rdbCenter_CheckedChanged);
            // 
            // rdbVänster
            // 
            this.rdbVänster.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbVänster.AutoSize = true;
            this.rdbVänster.Image = global::Skrivprogram___RichTextBox.Properties.Resources.left;
            this.rdbVänster.Location = new System.Drawing.Point(123, 58);
            this.rdbVänster.Name = "rdbVänster";
            this.rdbVänster.Size = new System.Drawing.Size(31, 31);
            this.rdbVänster.TabIndex = 1;
            this.rdbVänster.TabStop = true;
            this.rdbVänster.UseVisualStyleBackColor = true;
            this.rdbVänster.CheckedChanged += new System.EventHandler(this.rdbVänster_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inställningarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inställningarToolStripMenuItem
            // 
            this.inställningarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ändraIkonerToolStripMenuItem});
            this.inställningarToolStripMenuItem.Name = "inställningarToolStripMenuItem";
            this.inställningarToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.inställningarToolStripMenuItem.Text = "Inställningar";
            // 
            // ändraIkonerToolStripMenuItem
            // 
            this.ändraIkonerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vänsterToolStripMenuItem,
            this.mittenToolStripMenuItem,
            this.högerToolStripMenuItem});
            this.ändraIkonerToolStripMenuItem.Name = "ändraIkonerToolStripMenuItem";
            this.ändraIkonerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ändraIkonerToolStripMenuItem.Text = "Ändra ikoner";
            // 
            // vänsterToolStripMenuItem
            // 
            this.vänsterToolStripMenuItem.Name = "vänsterToolStripMenuItem";
            this.vänsterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vänsterToolStripMenuItem.Text = "Vänster";
            this.vänsterToolStripMenuItem.Click += new System.EventHandler(this.vänsterToolStripMenuItem_Click);
            // 
            // mittenToolStripMenuItem
            // 
            this.mittenToolStripMenuItem.Name = "mittenToolStripMenuItem";
            this.mittenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mittenToolStripMenuItem.Text = "Mitten";
            this.mittenToolStripMenuItem.Click += new System.EventHandler(this.mittenToolStripMenuItem_Click);
            // 
            // högerToolStripMenuItem
            // 
            this.högerToolStripMenuItem.Name = "högerToolStripMenuItem";
            this.högerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.högerToolStripMenuItem.Text = "Höger";
            this.högerToolStripMenuItem.Click += new System.EventHandler(this.högerToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rdbHöger);
            this.Controls.Add(this.rdbCenter);
            this.Controls.Add(this.rdbVänster);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.RadioButton rdbVänster;
        private System.Windows.Forms.RadioButton rdbCenter;
        private System.Windows.Forms.RadioButton rdbHöger;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inställningarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ändraIkonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vänsterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mittenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem högerToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

