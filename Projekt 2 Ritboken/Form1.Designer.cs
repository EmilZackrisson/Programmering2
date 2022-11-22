namespace Projekt_2_Ritboken
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
            this.pnDraw = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbrPenThickness = new System.Windows.Forms.TrackBar();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.pnIndigo = new System.Windows.Forms.Panel();
            this.pnHotPink = new System.Windows.Forms.Panel();
            this.pnMagenta = new System.Windows.Forms.Panel();
            this.pnCyan = new System.Windows.Forms.Panel();
            this.pnYellow = new System.Windows.Forms.Panel();
            this.pnBlue = new System.Windows.Forms.Panel();
            this.pnRed = new System.Windows.Forms.Panel();
            this.pnWhite = new System.Windows.Forms.Panel();
            this.pnBlack = new System.Windows.Forms.Panel();
            this.pnGreen = new System.Windows.Forms.Panel();
            this.gbxVerktyg = new System.Windows.Forms.GroupBox();
            this.rdbPenna = new System.Windows.Forms.RadioButton();
            this.rdbRect = new System.Windows.Forms.RadioButton();
            this.rdbLine = new System.Windows.Forms.RadioButton();
            this.rdbCirkel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPenThickness)).BeginInit();
            this.gbColor.SuspendLayout();
            this.gbxVerktyg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDraw
            // 
            this.pnDraw.BackColor = System.Drawing.Color.White;
            this.pnDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDraw.Location = new System.Drawing.Point(388, 12);
            this.pnDraw.Name = "pnDraw";
            this.pnDraw.Size = new System.Drawing.Size(400, 400);
            this.pnDraw.TabIndex = 0;
            this.pnDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnDraw_MouseClick);
            this.pnDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnDraw_MouseMove);
            this.pnDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnDraw_MouseMove);
            this.pnDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnDraw_MouseUp);
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo.Location = new System.Drawing.Point(12, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(370, 23);
            this.lblInfo.TabIndex = 1;
            // 
            // tbrPenThickness
            // 
            this.tbrPenThickness.Location = new System.Drawing.Point(12, 38);
            this.tbrPenThickness.Minimum = 1;
            this.tbrPenThickness.Name = "tbrPenThickness";
            this.tbrPenThickness.Size = new System.Drawing.Size(370, 45);
            this.tbrPenThickness.TabIndex = 2;
            this.tbrPenThickness.Value = 1;
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.pnIndigo);
            this.gbColor.Controls.Add(this.pnHotPink);
            this.gbColor.Controls.Add(this.pnMagenta);
            this.gbColor.Controls.Add(this.pnCyan);
            this.gbColor.Controls.Add(this.pnYellow);
            this.gbColor.Controls.Add(this.pnBlue);
            this.gbColor.Controls.Add(this.pnRed);
            this.gbColor.Controls.Add(this.pnWhite);
            this.gbColor.Controls.Add(this.pnBlack);
            this.gbColor.Controls.Add(this.pnGreen);
            this.gbColor.Location = new System.Drawing.Point(12, 308);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(216, 106);
            this.gbColor.TabIndex = 3;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Färger";
            // 
            // pnIndigo
            // 
            this.pnIndigo.BackColor = System.Drawing.Color.Indigo;
            this.pnIndigo.Location = new System.Drawing.Point(170, 60);
            this.pnIndigo.Name = "pnIndigo";
            this.pnIndigo.Size = new System.Drawing.Size(35, 35);
            this.pnIndigo.TabIndex = 8;
            this.pnIndigo.Click += new System.EventHandler(this.pnColor_Click);
            // 
            // pnHotPink
            // 
            this.pnHotPink.BackColor = System.Drawing.Color.HotPink;
            this.pnHotPink.Location = new System.Drawing.Point(129, 60);
            this.pnHotPink.Name = "pnHotPink";
            this.pnHotPink.Size = new System.Drawing.Size(35, 35);
            this.pnHotPink.TabIndex = 7;
            this.pnHotPink.Click += new System.EventHandler(this.pnColor_Click);
            // 
            // pnMagenta
            // 
            this.pnMagenta.BackColor = System.Drawing.Color.Magenta;
            this.pnMagenta.Location = new System.Drawing.Point(88, 60);
            this.pnMagenta.Name = "pnMagenta";
            this.pnMagenta.Size = new System.Drawing.Size(35, 35);
            this.pnMagenta.TabIndex = 6;
            this.pnMagenta.Click += new System.EventHandler(this.pnColor_Click);
            // 
            // pnCyan
            // 
            this.pnCyan.BackColor = System.Drawing.Color.Cyan;
            this.pnCyan.Location = new System.Drawing.Point(47, 60);
            this.pnCyan.Name = "pnCyan";
            this.pnCyan.Size = new System.Drawing.Size(35, 35);
            this.pnCyan.TabIndex = 5;
            this.pnCyan.Click += new System.EventHandler(this.pnColor_Click);
            // 
            // pnYellow
            // 
            this.pnYellow.BackColor = System.Drawing.Color.Yellow;
            this.pnYellow.Location = new System.Drawing.Point(6, 60);
            this.pnYellow.Name = "pnYellow";
            this.pnYellow.Size = new System.Drawing.Size(35, 35);
            this.pnYellow.TabIndex = 4;
            this.pnYellow.Click += new System.EventHandler(this.pnColor_Click);
            // 
            // pnBlue
            // 
            this.pnBlue.BackColor = System.Drawing.Color.Blue;
            this.pnBlue.Location = new System.Drawing.Point(170, 19);
            this.pnBlue.Name = "pnBlue";
            this.pnBlue.Size = new System.Drawing.Size(35, 35);
            this.pnBlue.TabIndex = 3;
            this.pnBlue.Click += new System.EventHandler(this.pnColor_Click);
            // 
            // pnRed
            // 
            this.pnRed.BackColor = System.Drawing.Color.Red;
            this.pnRed.Location = new System.Drawing.Point(129, 19);
            this.pnRed.Name = "pnRed";
            this.pnRed.Size = new System.Drawing.Size(35, 35);
            this.pnRed.TabIndex = 2;
            this.pnRed.Click += new System.EventHandler(this.pnColor_Click);
            // 
            // pnWhite
            // 
            this.pnWhite.BackColor = System.Drawing.Color.White;
            this.pnWhite.Location = new System.Drawing.Point(88, 19);
            this.pnWhite.Name = "pnWhite";
            this.pnWhite.Size = new System.Drawing.Size(35, 35);
            this.pnWhite.TabIndex = 2;
            this.pnWhite.Click += new System.EventHandler(this.pnColor_Click);
            // 
            // pnBlack
            // 
            this.pnBlack.BackColor = System.Drawing.Color.Black;
            this.pnBlack.Location = new System.Drawing.Point(47, 19);
            this.pnBlack.Name = "pnBlack";
            this.pnBlack.Size = new System.Drawing.Size(35, 35);
            this.pnBlack.TabIndex = 1;
            this.pnBlack.Click += new System.EventHandler(this.pnColor_Click);
            // 
            // pnGreen
            // 
            this.pnGreen.BackColor = System.Drawing.Color.Lime;
            this.pnGreen.Location = new System.Drawing.Point(6, 19);
            this.pnGreen.Name = "pnGreen";
            this.pnGreen.Size = new System.Drawing.Size(35, 35);
            this.pnGreen.TabIndex = 0;
            this.pnGreen.Click += new System.EventHandler(this.pnColor_Click);
            // 
            // gbxVerktyg
            // 
            this.gbxVerktyg.Controls.Add(this.rdbCirkel);
            this.gbxVerktyg.Controls.Add(this.rdbPenna);
            this.gbxVerktyg.Controls.Add(this.rdbRect);
            this.gbxVerktyg.Controls.Add(this.rdbLine);
            this.gbxVerktyg.Location = new System.Drawing.Point(12, 89);
            this.gbxVerktyg.Name = "gbxVerktyg";
            this.gbxVerktyg.Size = new System.Drawing.Size(200, 133);
            this.gbxVerktyg.TabIndex = 4;
            this.gbxVerktyg.TabStop = false;
            this.gbxVerktyg.Text = "Verktyg";
            // 
            // rdbPenna
            // 
            this.rdbPenna.AutoSize = true;
            this.rdbPenna.Location = new System.Drawing.Point(7, 67);
            this.rdbPenna.Name = "rdbPenna";
            this.rdbPenna.Size = new System.Drawing.Size(56, 17);
            this.rdbPenna.TabIndex = 2;
            this.rdbPenna.TabStop = true;
            this.rdbPenna.Text = "Penna";
            this.rdbPenna.UseVisualStyleBackColor = true;
            this.rdbPenna.CheckedChanged += new System.EventHandler(this.changeTool);
            // 
            // rdbRect
            // 
            this.rdbRect.AutoSize = true;
            this.rdbRect.Location = new System.Drawing.Point(7, 44);
            this.rdbRect.Name = "rdbRect";
            this.rdbRect.Size = new System.Drawing.Size(74, 17);
            this.rdbRect.TabIndex = 1;
            this.rdbRect.Text = "Rektangel";
            this.rdbRect.UseVisualStyleBackColor = true;
            this.rdbRect.CheckedChanged += new System.EventHandler(this.changeTool);
            // 
            // rdbLine
            // 
            this.rdbLine.AutoSize = true;
            this.rdbLine.Checked = true;
            this.rdbLine.Location = new System.Drawing.Point(7, 20);
            this.rdbLine.Name = "rdbLine";
            this.rdbLine.Size = new System.Drawing.Size(47, 17);
            this.rdbLine.TabIndex = 0;
            this.rdbLine.TabStop = true;
            this.rdbLine.Text = "Linje";
            this.rdbLine.UseVisualStyleBackColor = true;
            this.rdbLine.CheckedChanged += new System.EventHandler(this.changeTool);
            // 
            // rdbCirkel
            // 
            this.rdbCirkel.AutoSize = true;
            this.rdbCirkel.Location = new System.Drawing.Point(7, 90);
            this.rdbCirkel.Name = "rdbCirkel";
            this.rdbCirkel.Size = new System.Drawing.Size(51, 17);
            this.rdbCirkel.TabIndex = 3;
            this.rdbCirkel.TabStop = true;
            this.rdbCirkel.Text = "Cirkel";
            this.rdbCirkel.UseVisualStyleBackColor = true;
            this.rdbCirkel.CheckedChanged += new System.EventHandler(this.changeTool);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.gbxVerktyg);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.tbrPenThickness);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbrPenThickness)).EndInit();
            this.gbColor.ResumeLayout(false);
            this.gbxVerktyg.ResumeLayout(false);
            this.gbxVerktyg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDraw;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TrackBar tbrPenThickness;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.Panel pnGreen;
        private System.Windows.Forms.Panel pnBlack;
        private System.Windows.Forms.Panel pnWhite;
        private System.Windows.Forms.Panel pnBlue;
        private System.Windows.Forms.Panel pnRed;
        private System.Windows.Forms.Panel pnYellow;
        private System.Windows.Forms.Panel pnCyan;
        private System.Windows.Forms.Panel pnMagenta;
        private System.Windows.Forms.Panel pnIndigo;
        private System.Windows.Forms.Panel pnHotPink;
        private System.Windows.Forms.GroupBox gbxVerktyg;
        private System.Windows.Forms.RadioButton rdbRect;
        private System.Windows.Forms.RadioButton rdbLine;
        private System.Windows.Forms.RadioButton rdbPenna;
        private System.Windows.Forms.RadioButton rdbCirkel;
    }
}

