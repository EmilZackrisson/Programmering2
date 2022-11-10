namespace v36_2
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
            this.tbxExakt = new System.Windows.Forms.TextBox();
            this.tbxAvrundat = new System.Windows.Forms.TextBox();
            this.btnAvrunda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exakt värde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Avrundat värde";
            // 
            // tbxExakt
            // 
            this.tbxExakt.Location = new System.Drawing.Point(99, 10);
            this.tbxExakt.Name = "tbxExakt";
            this.tbxExakt.Size = new System.Drawing.Size(100, 20);
            this.tbxExakt.TabIndex = 2;
            // 
            // tbxAvrundat
            // 
            this.tbxAvrundat.Location = new System.Drawing.Point(99, 44);
            this.tbxAvrundat.Name = "tbxAvrundat";
            this.tbxAvrundat.Size = new System.Drawing.Size(100, 20);
            this.tbxAvrundat.TabIndex = 3;
            // 
            // btnAvrunda
            // 
            this.btnAvrunda.Location = new System.Drawing.Point(124, 92);
            this.btnAvrunda.Name = "btnAvrunda";
            this.btnAvrunda.Size = new System.Drawing.Size(75, 23);
            this.btnAvrunda.TabIndex = 4;
            this.btnAvrunda.Text = "Avrunda";
            this.btnAvrunda.UseVisualStyleBackColor = true;
            this.btnAvrunda.Click += new System.EventHandler(this.btnAvrunda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 126);
            this.Controls.Add(this.btnAvrunda);
            this.Controls.Add(this.tbxAvrundat);
            this.Controls.Add(this.tbxExakt);
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
        private System.Windows.Forms.TextBox tbxExakt;
        private System.Windows.Forms.TextBox tbxAvrundat;
        private System.Windows.Forms.Button btnAvrunda;
    }
}

