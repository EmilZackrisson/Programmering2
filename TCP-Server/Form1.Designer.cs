namespace TCP_Server
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
            this.rtbInkorg = new System.Windows.Forms.RichTextBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnBall = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.lblLeftPoints = new System.Windows.Forms.Label();
            this.lblRightPoints = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbInkorg
            // 
            this.rtbInkorg.Enabled = false;
            this.rtbInkorg.Location = new System.Drawing.Point(12, 57);
            this.rtbInkorg.Name = "rtbInkorg";
            this.rtbInkorg.ReadOnly = true;
            this.rtbInkorg.Size = new System.Drawing.Size(568, 489);
            this.rtbInkorg.TabIndex = 0;
            this.rtbInkorg.Text = "";
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(122, 12);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(75, 23);
            this.btnStartServer.TabIndex = 1;
            this.btnStartServer.Text = "Starta server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inkorg";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pnBottom);
            this.panel1.Controls.Add(this.pnTop);
            this.panel1.Controls.Add(this.pnBall);
            this.panel1.Controls.Add(this.pnRight);
            this.panel1.Controls.Add(this.pnLeft);
            this.panel1.Location = new System.Drawing.Point(586, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 489);
            this.panel1.TabIndex = 3;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.White;
            this.pnLeft.Location = new System.Drawing.Point(3, 194);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(6, 50);
            this.pnLeft.TabIndex = 0;
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.White;
            this.pnRight.Location = new System.Drawing.Point(806, 194);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(6, 50);
            this.pnRight.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnBall
            // 
            this.pnBall.BackColor = System.Drawing.Color.White;
            this.pnBall.Location = new System.Drawing.Point(382, 234);
            this.pnBall.Name = "pnBall";
            this.pnBall.Size = new System.Drawing.Size(10, 10);
            this.pnBall.TabIndex = 2;
            // 
            // pnTop
            // 
            this.pnTop.Location = new System.Drawing.Point(0, -6);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(815, 10);
            this.pnTop.TabIndex = 3;
            // 
            // pnBottom
            // 
            this.pnBottom.Location = new System.Drawing.Point(-1, 484);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(815, 10);
            this.pnBottom.TabIndex = 4;
            // 
            // lblLeftPoints
            // 
            this.lblLeftPoints.AutoSize = true;
            this.lblLeftPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftPoints.Location = new System.Drawing.Point(583, 17);
            this.lblLeftPoints.Name = "lblLeftPoints";
            this.lblLeftPoints.Size = new System.Drawing.Size(30, 31);
            this.lblLeftPoints.TabIndex = 4;
            this.lblLeftPoints.Text = "0";
            // 
            // lblRightPoints
            // 
            this.lblRightPoints.AutoSize = true;
            this.lblRightPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightPoints.Location = new System.Drawing.Point(1371, 20);
            this.lblRightPoints.Name = "lblRightPoints";
            this.lblRightPoints.Size = new System.Drawing.Size(30, 31);
            this.lblRightPoints.TabIndex = 5;
            this.lblRightPoints.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 557);
            this.Controls.Add(this.lblRightPoints);
            this.Controls.Add(this.lblLeftPoints);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.rtbInkorg);
            this.Name = "Form1";
            this.Text = "TCP-Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInkorg;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnBall;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblLeftPoints;
        private System.Windows.Forms.Label lblRightPoints;
    }
}

