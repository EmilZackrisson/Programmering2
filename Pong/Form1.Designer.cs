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
            this.boll = new System.Windows.Forms.PictureBox();
            this.spelare = new System.Windows.Forms.PictureBox();
            this.motståndare = new System.Windows.Forms.PictureBox();
            this.gbxMenu = new System.Windows.Forms.GroupBox();
            this.gbxJoin = new System.Windows.Forms.GroupBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.boll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motståndare)).BeginInit();
            this.gbxMenu.SuspendLayout();
            this.gbxJoin.SuspendLayout();
            this.SuspendLayout();
            // 
            // boll
            // 
            this.boll.BackgroundImage = global::Pong.Properties.Resources.Boll;
            this.boll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boll.Location = new System.Drawing.Point(375, 212);
            this.boll.Name = "boll";
            this.boll.Size = new System.Drawing.Size(9, 9);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.gbxMenu);
            this.Controls.Add(this.boll);
            this.Controls.Add(this.spelare);
            this.Controls.Add(this.motståndare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.boll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motståndare)).EndInit();
            this.gbxMenu.ResumeLayout(false);
            this.gbxJoin.ResumeLayout(false);
            this.gbxJoin.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

