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
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ändraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopieraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klippUtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klistraInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markeraAlltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ångraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görOmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inställningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ändraIkonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vänsterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mittenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.högerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cbxFonts = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbxBold = new System.Windows.Forms.CheckBox();
            this.cbxItalic = new System.Windows.Forms.CheckBox();
            this.lblAntalOrd = new System.Windows.Forms.Label();
            this.lblAntalTecken = new System.Windows.Forms.Label();
            this.lblRad = new System.Windows.Forms.Label();
            this.lblPlats = new System.Windows.Forms.Label();
            this.nudTabSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTabSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFont
            // 
            this.btnFont.AutoSize = true;
            this.btnFont.Location = new System.Drawing.Point(12, 494);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(88, 23);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "Teckensnitt";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Location = new System.Drawing.Point(12, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(810, 429);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.Location = new System.Drawing.Point(500, 31);
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
            this.rdbHöger.Location = new System.Drawing.Point(408, 27);
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
            this.rdbCenter.Location = new System.Drawing.Point(371, 27);
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
            this.rdbVänster.Location = new System.Drawing.Point(334, 27);
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
            this.arkivToolStripMenuItem,
            this.ändraToolStripMenuItem,
            this.inställningarToolStripMenuItem,
            this.stilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyttToolStripMenuItem,
            this.öppnaToolStripMenuItem,
            this.sparaToolStripMenuItem1,
            this.sparaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // nyttToolStripMenuItem
            // 
            this.nyttToolStripMenuItem.Name = "nyttToolStripMenuItem";
            this.nyttToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nyttToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.nyttToolStripMenuItem.Text = "Nytt";
            this.nyttToolStripMenuItem.Click += new System.EventHandler(this.nyttToolStripMenuItem_Click);
            // 
            // öppnaToolStripMenuItem
            // 
            this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
            this.öppnaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.öppnaToolStripMenuItem.Text = "Öppna";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.öppnaToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem1
            // 
            this.sparaToolStripMenuItem1.Name = "sparaToolStripMenuItem1";
            this.sparaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sparaToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.sparaToolStripMenuItem1.Text = "Spara";
            this.sparaToolStripMenuItem1.Click += new System.EventHandler(this.sparaToolStripMenuItem1_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.sparaToolStripMenuItem.Text = "Spara som";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
            // 
            // ändraToolStripMenuItem
            // 
            this.ändraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopieraToolStripMenuItem,
            this.klippUtToolStripMenuItem,
            this.klistraInToolStripMenuItem,
            this.markeraAlltToolStripMenuItem,
            this.ångraToolStripMenuItem,
            this.görOmToolStripMenuItem});
            this.ändraToolStripMenuItem.Name = "ändraToolStripMenuItem";
            this.ändraToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ändraToolStripMenuItem.Text = "Ändra";
            // 
            // kopieraToolStripMenuItem
            // 
            this.kopieraToolStripMenuItem.Name = "kopieraToolStripMenuItem";
            this.kopieraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopieraToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.kopieraToolStripMenuItem.Text = "Kopiera";
            this.kopieraToolStripMenuItem.Click += new System.EventHandler(this.kopieraToolStripMenuItem_Click);
            // 
            // klippUtToolStripMenuItem
            // 
            this.klippUtToolStripMenuItem.Name = "klippUtToolStripMenuItem";
            this.klippUtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.klippUtToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.klippUtToolStripMenuItem.Text = "Klipp ut";
            this.klippUtToolStripMenuItem.Click += new System.EventHandler(this.klippUtToolStripMenuItem_Click);
            // 
            // klistraInToolStripMenuItem
            // 
            this.klistraInToolStripMenuItem.Name = "klistraInToolStripMenuItem";
            this.klistraInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.klistraInToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.klistraInToolStripMenuItem.Text = "Klistra in";
            this.klistraInToolStripMenuItem.Click += new System.EventHandler(this.klistraInToolStripMenuItem_Click);
            // 
            // markeraAlltToolStripMenuItem
            // 
            this.markeraAlltToolStripMenuItem.Name = "markeraAlltToolStripMenuItem";
            this.markeraAlltToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.markeraAlltToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.markeraAlltToolStripMenuItem.Text = "Markera allt";
            this.markeraAlltToolStripMenuItem.Click += new System.EventHandler(this.markeraAlltToolStripMenuItem_Click);
            // 
            // ångraToolStripMenuItem
            // 
            this.ångraToolStripMenuItem.Name = "ångraToolStripMenuItem";
            this.ångraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ångraToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ångraToolStripMenuItem.Text = "Ångra";
            this.ångraToolStripMenuItem.Click += new System.EventHandler(this.ångraToolStripMenuItem_Click);
            // 
            // görOmToolStripMenuItem
            // 
            this.görOmToolStripMenuItem.Name = "görOmToolStripMenuItem";
            this.görOmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.görOmToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.görOmToolStripMenuItem.Text = "Gör om";
            this.görOmToolStripMenuItem.Click += new System.EventHandler(this.görOmToolStripMenuItem_Click);
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
            this.ändraIkonerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ändraIkonerToolStripMenuItem.Text = "Ändra ikoner";
            // 
            // vänsterToolStripMenuItem
            // 
            this.vänsterToolStripMenuItem.Name = "vänsterToolStripMenuItem";
            this.vänsterToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.vänsterToolStripMenuItem.Text = "Vänster";
            this.vänsterToolStripMenuItem.Click += new System.EventHandler(this.vänsterToolStripMenuItem_Click);
            // 
            // mittenToolStripMenuItem
            // 
            this.mittenToolStripMenuItem.Name = "mittenToolStripMenuItem";
            this.mittenToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.mittenToolStripMenuItem.Text = "Mitten";
            this.mittenToolStripMenuItem.Click += new System.EventHandler(this.mittenToolStripMenuItem_Click);
            // 
            // högerToolStripMenuItem
            // 
            this.högerToolStripMenuItem.Name = "högerToolStripMenuItem";
            this.högerToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.högerToolStripMenuItem.Text = "Höger";
            this.högerToolStripMenuItem.Click += new System.EventHandler(this.högerToolStripMenuItem_Click);
            // 
            // stilToolStripMenuItem
            // 
            this.stilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem});
            this.stilToolStripMenuItem.Name = "stilToolStripMenuItem";
            this.stilToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.stilToolStripMenuItem.Text = "Stil";
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.skitformat";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Skitformatfiler | *.skitformat";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.skitformat";
            this.saveFileDialog1.Filter = "Skitformat Filer|*.skitformat";
            // 
            // cbxFonts
            // 
            this.cbxFonts.FormattingEnabled = true;
            this.cbxFonts.Location = new System.Drawing.Point(12, 33);
            this.cbxFonts.Name = "cbxFonts";
            this.cbxFonts.Size = new System.Drawing.Size(121, 21);
            this.cbxFonts.TabIndex = 7;
            this.cbxFonts.SelectedValueChanged += new System.EventHandler(this.cbxFonts_SelectedValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(139, 33);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cbxBold
            // 
            this.cbxBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxBold.AutoSize = true;
            this.cbxBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBold.Location = new System.Drawing.Point(177, 31);
            this.cbxBold.Name = "cbxBold";
            this.cbxBold.Size = new System.Drawing.Size(25, 23);
            this.cbxBold.TabIndex = 9;
            this.cbxBold.Text = "B";
            this.cbxBold.UseVisualStyleBackColor = true;
            this.cbxBold.CheckedChanged += new System.EventHandler(this.cbxBold_CheckedChanged);
            // 
            // cbxItalic
            // 
            this.cbxItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxItalic.AutoSize = true;
            this.cbxItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItalic.Location = new System.Drawing.Point(208, 31);
            this.cbxItalic.Name = "cbxItalic";
            this.cbxItalic.Size = new System.Drawing.Size(20, 23);
            this.cbxItalic.TabIndex = 10;
            this.cbxItalic.Text = "I";
            this.cbxItalic.UseVisualStyleBackColor = true;
            this.cbxItalic.CheckedChanged += new System.EventHandler(this.cbxItalic_CheckedChanged);
            // 
            // lblAntalOrd
            // 
            this.lblAntalOrd.AutoSize = true;
            this.lblAntalOrd.Location = new System.Drawing.Point(568, 27);
            this.lblAntalOrd.Name = "lblAntalOrd";
            this.lblAntalOrd.Size = new System.Drawing.Size(53, 13);
            this.lblAntalOrd.TabIndex = 12;
            this.lblAntalOrd.Text = "Ordantal: ";
            // 
            // lblAntalTecken
            // 
            this.lblAntalTecken.AutoSize = true;
            this.lblAntalTecken.Location = new System.Drawing.Point(544, 42);
            this.lblAntalTecken.Name = "lblAntalTecken";
            this.lblAntalTecken.Size = new System.Drawing.Size(74, 13);
            this.lblAntalTecken.TabIndex = 14;
            this.lblAntalTecken.Text = "Antal Tecken:";
            // 
            // lblRad
            // 
            this.lblRad.AutoSize = true;
            this.lblRad.Location = new System.Drawing.Point(696, 27);
            this.lblRad.Name = "lblRad";
            this.lblRad.Size = new System.Drawing.Size(33, 13);
            this.lblRad.TabIndex = 15;
            this.lblRad.Text = "Rad: ";
            // 
            // lblPlats
            // 
            this.lblPlats.AutoSize = true;
            this.lblPlats.Location = new System.Drawing.Point(696, 43);
            this.lblPlats.Name = "lblPlats";
            this.lblPlats.Size = new System.Drawing.Size(33, 13);
            this.lblPlats.TabIndex = 16;
            this.lblPlats.Text = "Plats:";
            // 
            // nudTabSize
            // 
            this.nudTabSize.Location = new System.Drawing.Point(407, 497);
            this.nudTabSize.Name = "nudTabSize";
            this.nudTabSize.Size = new System.Drawing.Size(32, 20);
            this.nudTabSize.TabIndex = 17;
            this.nudTabSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudTabSize.ValueChanged += new System.EventHandler(this.nudTabSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tab-storlek:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTabSize);
            this.Controls.Add(this.lblPlats);
            this.Controls.Add(this.lblRad);
            this.Controls.Add(this.lblAntalTecken);
            this.Controls.Add(this.lblAntalOrd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.cbxItalic);
            this.Controls.Add(this.cbxBold);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbxFonts);
            this.Controls.Add(this.rdbHöger);
            this.Controls.Add(this.rdbCenter);
            this.Controls.Add(this.rdbVänster);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Skrivprogram";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTabSize)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cbxFonts;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox cbxBold;
        private System.Windows.Forms.CheckBox cbxItalic;
        private System.Windows.Forms.ToolStripMenuItem nyttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem1;
        private System.Windows.Forms.Label lblAntalOrd;
        private System.Windows.Forms.Label lblAntalTecken;
        private System.Windows.Forms.Label lblRad;
        private System.Windows.Forms.Label lblPlats;
        private System.Windows.Forms.ToolStripMenuItem ändraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopieraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klippUtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klistraInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markeraAlltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ångraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görOmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudTabSize;
        private System.Windows.Forms.Label label1;
    }
}

