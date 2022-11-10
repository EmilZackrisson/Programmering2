namespace Klass
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
            this.lblTal = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxTal = new System.Windows.Forms.TextBox();
            this.btnÄndra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTal
            // 
            this.lblTal.AutoSize = true;
            this.lblTal.Location = new System.Drawing.Point(13, 13);
            this.lblTal.Name = "lblTal";
            this.lblTal.Size = new System.Drawing.Size(34, 13);
            this.lblTal.TabIndex = 0;
            this.lblTal.Text = "Talet:";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(16, 36);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 1;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxTal
            // 
            this.tbxTal.Location = new System.Drawing.Point(153, 10);
            this.tbxTal.Name = "tbxTal";
            this.tbxTal.Size = new System.Drawing.Size(100, 20);
            this.tbxTal.TabIndex = 2;
            this.tbxTal.TextChanged += new System.EventHandler(this.tbxTal_TextChanged);
            // 
            // btnÄndra
            // 
            this.btnÄndra.Location = new System.Drawing.Point(153, 36);
            this.btnÄndra.Name = "btnÄndra";
            this.btnÄndra.Size = new System.Drawing.Size(75, 23);
            this.btnÄndra.TabIndex = 3;
            this.btnÄndra.Text = "Ändra";
            this.btnÄndra.UseVisualStyleBackColor = true;
            this.btnÄndra.Click += new System.EventHandler(this.btnÄndra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 72);
            this.Controls.Add(this.btnÄndra);
            this.Controls.Add(this.tbxTal);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblTal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTal;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxTal;
        private System.Windows.Forms.Button btnÄndra;
    }
}

