namespace Pong
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
            this.boll = new System.Windows.Forms.PictureBox();
            this.spelare = new System.Windows.Forms.PictureBox();
            this.motståndare = new System.Windows.Forms.PictureBox();
            this.gbxMenu = new System.Windows.Forms.GroupBox();
            this.gbxJoin = new System.Windows.Forms.GroupBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIp = new System.Windows.Forms.TextBox();
            this.lblKord = new System.Windows.Forms.Label();
            this.lblUppeVänster = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.lblLeftPoint = new System.Windows.Forms.Label();
            this.lblPointRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motståndare)).BeginInit();
            this.gbxMenu.SuspendLayout();
            this.gbxJoin.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boll
            // 
            this.boll.BackgroundImage = global::Pong.Properties.Resources.Boll;
            this.boll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boll.Location = new System.Drawing.Point(375, 212);
            this.boll.Name = "boll";
            this.boll.Size = new System.Drawing.Size(10, 10);
            this.boll.TabIndex = 2;
            this.boll.TabStop = false;
            // 
            // spelare
            // 
            this.spelare.BackgroundImage = global::Pong.Properties.Resources.Platta;
            this.spelare.Location = new System.Drawing.Point(787, 171);
            this.spelare.Name = "spelare";
            this.spelare.Size = new System.Drawing.Size(6, 50);
            this.spelare.TabIndex = 1;
            this.spelare.TabStop = false;
            // 
            // motståndare
            // 
            this.motståndare.BackgroundImage = global::Pong.Properties.Resources.Platta;
            this.motståndare.Location = new System.Drawing.Point(6, 171);
            this.motståndare.Name = "motståndare";
            this.motståndare.Size = new System.Drawing.Size(6, 50);
            this.motståndare.TabIndex = 0;
            this.motståndare.TabStop = false;
            // 
            // gbxMenu
            // 
            this.gbxMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbxMenu.Controls.Add(this.gbxJoin);
            this.gbxMenu.Location = new System.Drawing.Point(429, 112);
            this.gbxMenu.Name = "gbxMenu";
            this.gbxMenu.Size = new System.Drawing.Size(269, 109);
            this.gbxMenu.TabIndex = 3;
            this.gbxMenu.TabStop = false;
            this.gbxMenu.Text = "Meny";
            // 
            // gbxJoin
            // 
            this.gbxJoin.Controls.Add(this.btnJoin);
            this.gbxJoin.Controls.Add(this.label1);
            this.gbxJoin.Controls.Add(this.tbxIp);
            this.gbxJoin.Location = new System.Drawing.Point(6, 19);
            this.gbxJoin.Name = "gbxJoin";
            this.gbxJoin.Size = new System.Drawing.Size(256, 81);
            this.gbxJoin.TabIndex = 1;
            this.gbxJoin.TabStop = false;
            this.gbxJoin.Text = "Gå med";
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(9, 45);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "Gå med";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP-address";
            // 
            // tbxIp
            // 
            this.tbxIp.Location = new System.Drawing.Point(69, 19);
            this.tbxIp.Name = "tbxIp";
            this.tbxIp.Size = new System.Drawing.Size(181, 20);
            this.tbxIp.TabIndex = 0;
            // 
            // lblKord
            // 
            this.lblKord.AutoSize = true;
            this.lblKord.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKord.Location = new System.Drawing.Point(348, 386);
            this.lblKord.Name = "lblKord";
            this.lblKord.Size = new System.Drawing.Size(35, 13);
            this.lblKord.TabIndex = 4;
            this.lblKord.Text = "label2";
            // 
            // lblUppeVänster
            // 
            this.lblUppeVänster.AutoSize = true;
            this.lblUppeVänster.ForeColor = System.Drawing.Color.White;
            this.lblUppeVänster.Location = new System.Drawing.Point(12, 9);
            this.lblUppeVänster.Name = "lblUppeVänster";
            this.lblUppeVänster.Size = new System.Drawing.Size(0, 13);
            this.lblUppeVänster.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.panel1);
            this.pnTop.Location = new System.Drawing.Point(-4, -11);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(811, 13);
            this.pnTop.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnLeft);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // pnLeft
            // 
            this.pnLeft.Location = new System.Drawing.Point(-5, 7);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(10, 463);
            this.pnLeft.TabIndex = 9;
            // 
            // pnBottom
            // 
            this.pnBottom.Location = new System.Drawing.Point(-5, 448);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(811, 13);
            this.pnBottom.TabIndex = 7;
            // 
            // pnRight
            // 
            this.pnRight.Location = new System.Drawing.Point(796, -2);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(10, 458);
            this.pnRight.TabIndex = 8;
            // 
            // lblLeftPoint
            // 
            this.lblLeftPoint.AutoSize = true;
            this.lblLeftPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftPoint.ForeColor = System.Drawing.Color.White;
            this.lblLeftPoint.Location = new System.Drawing.Point(12, 414);
            this.lblLeftPoint.Name = "lblLeftPoint";
            this.lblLeftPoint.Size = new System.Drawing.Size(29, 31);
            this.lblLeftPoint.TabIndex = 9;
            this.lblLeftPoint.Text = "0";
            // 
            // lblPointRight
            // 
            this.lblPointRight.AutoSize = true;
            this.lblPointRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointRight.ForeColor = System.Drawing.Color.White;
            this.lblPointRight.Location = new System.Drawing.Point(764, 414);
            this.lblPointRight.Name = "lblPointRight";
            this.lblPointRight.Size = new System.Drawing.Size(29, 31);
            this.lblPointRight.TabIndex = 10;
            this.lblPointRight.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.lblPointRight);
            this.Controls.Add(this.lblLeftPoint);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.lblUppeVänster);
            this.Controls.Add(this.lblKord);
            this.Controls.Add(this.gbxMenu);
            this.Controls.Add(this.boll);
            this.Controls.Add(this.spelare);
            this.Controls.Add(this.motståndare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.boll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motståndare)).EndInit();
            this.gbxMenu.ResumeLayout(false);
            this.gbxJoin.ResumeLayout(false);
            this.gbxJoin.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox motståndare;
        private System.Windows.Forms.PictureBox spelare;
        private System.Windows.Forms.PictureBox boll;
        private System.Windows.Forms.GroupBox gbxMenu;
        private System.Windows.Forms.GroupBox gbxJoin;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIp;
        private System.Windows.Forms.Label lblKord;
        private System.Windows.Forms.Label lblUppeVänster;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Label lblLeftPoint;
        private System.Windows.Forms.Label lblPointRight;
    }
}

