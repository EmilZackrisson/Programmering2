namespace Användarkonton
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAnvändare = new System.Windows.Forms.TextBox();
            this.tbxLösenord = new System.Windows.Forms.TextBox();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.btnLoggaIn = new System.Windows.Forms.Button();
            this.lbxAnvändare = new System.Windows.Forms.ListBox();
            this.lblVälkommen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Användare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lösenord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Användare";
            // 
            // tbxAnvändare
            // 
            this.tbxAnvändare.Location = new System.Drawing.Point(77, 10);
            this.tbxAnvändare.Name = "tbxAnvändare";
            this.tbxAnvändare.Size = new System.Drawing.Size(100, 20);
            this.tbxAnvändare.TabIndex = 3;
            // 
            // tbxLösenord
            // 
            this.tbxLösenord.Location = new System.Drawing.Point(77, 51);
            this.tbxLösenord.Name = "tbxLösenord";
            this.tbxLösenord.Size = new System.Drawing.Size(100, 20);
            this.tbxLösenord.TabIndex = 4;
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(15, 103);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrera.TabIndex = 5;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // btnLoggaIn
            // 
            this.btnLoggaIn.Location = new System.Drawing.Point(97, 103);
            this.btnLoggaIn.Name = "btnLoggaIn";
            this.btnLoggaIn.Size = new System.Drawing.Size(75, 23);
            this.btnLoggaIn.TabIndex = 6;
            this.btnLoggaIn.Text = "Logga in";
            this.btnLoggaIn.UseVisualStyleBackColor = true;
            this.btnLoggaIn.Click += new System.EventHandler(this.btnLoggaIn_Click);
            // 
            // lbxAnvändare
            // 
            this.lbxAnvändare.FormattingEnabled = true;
            this.lbxAnvändare.Location = new System.Drawing.Point(235, 31);
            this.lbxAnvändare.Name = "lbxAnvändare";
            this.lbxAnvändare.Size = new System.Drawing.Size(120, 95);
            this.lbxAnvändare.TabIndex = 7;
            // 
            // lblVälkommen
            // 
            this.lblVälkommen.BackColor = System.Drawing.Color.HotPink;
            this.lblVälkommen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVälkommen.Location = new System.Drawing.Point(16, 162);
            this.lblVälkommen.Name = "lblVälkommen";
            this.lblVälkommen.Size = new System.Drawing.Size(339, 100);
            this.lblVälkommen.TabIndex = 8;
            this.lblVälkommen.Text = "label4";
            this.lblVälkommen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVälkommen.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 296);
            this.Controls.Add(this.lblVälkommen);
            this.Controls.Add(this.lbxAnvändare);
            this.Controls.Add(this.btnLoggaIn);
            this.Controls.Add(this.btnRegistrera);
            this.Controls.Add(this.tbxLösenord);
            this.Controls.Add(this.tbxAnvändare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAnvändare;
        private System.Windows.Forms.TextBox tbxLösenord;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.Button btnLoggaIn;
        private System.Windows.Forms.ListBox lbxAnvändare;
        private System.Windows.Forms.Label lblVälkommen;
    }
}

