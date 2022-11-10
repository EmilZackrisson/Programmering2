namespace Exempel_2._3
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
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.tbxFörsäljning = new System.Windows.Forms.TextBox();
            this.tbxProvision = new System.Windows.Forms.TextBox();
            this.btnRäkna = new System.Windows.Forms.Button();
            this.lblLön = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Försäljning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Provision";
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(82, 25);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxNamn.TabIndex = 3;
            // 
            // tbxFörsäljning
            // 
            this.tbxFörsäljning.Location = new System.Drawing.Point(82, 51);
            this.tbxFörsäljning.Name = "tbxFörsäljning";
            this.tbxFörsäljning.Size = new System.Drawing.Size(100, 20);
            this.tbxFörsäljning.TabIndex = 4;
            // 
            // tbxProvision
            // 
            this.tbxProvision.Location = new System.Drawing.Point(82, 77);
            this.tbxProvision.Name = "tbxProvision";
            this.tbxProvision.Size = new System.Drawing.Size(100, 20);
            this.tbxProvision.TabIndex = 5;
            // 
            // btnRäkna
            // 
            this.btnRäkna.Location = new System.Drawing.Point(107, 120);
            this.btnRäkna.Name = "btnRäkna";
            this.btnRäkna.Size = new System.Drawing.Size(75, 23);
            this.btnRäkna.TabIndex = 6;
            this.btnRäkna.Text = "Beräkna";
            this.btnRäkna.UseVisualStyleBackColor = true;
            this.btnRäkna.Click += new System.EventHandler(this.btnRäkna_Click);
            // 
            // lblLön
            // 
            this.lblLön.AutoSize = true;
            this.lblLön.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLön.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLön.Location = new System.Drawing.Point(12, 171);
            this.lblLön.Name = "lblLön";
            this.lblLön.Size = new System.Drawing.Size(2, 39);
            this.lblLön.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 257);
            this.Controls.Add(this.lblLön);
            this.Controls.Add(this.btnRäkna);
            this.Controls.Add(this.tbxProvision);
            this.Controls.Add(this.tbxFörsäljning);
            this.Controls.Add(this.tbxNamn);
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
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.TextBox tbxFörsäljning;
        private System.Windows.Forms.TextBox tbxProvision;
        private System.Windows.Forms.Button btnRäkna;
        private System.Windows.Forms.Label lblLön;
    }
}

