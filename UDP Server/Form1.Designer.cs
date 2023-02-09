namespace UDP_Server
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
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbReccived = new System.Windows.Forms.RichTextBox();
            this.btnTagEmot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(47, 24);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(100, 20);
            this.tbxPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // rtbReccived
            // 
            this.rtbReccived.Location = new System.Drawing.Point(15, 63);
            this.rtbReccived.Name = "rtbReccived";
            this.rtbReccived.Size = new System.Drawing.Size(150, 115);
            this.rtbReccived.TabIndex = 2;
            this.rtbReccived.Text = "";
            // 
            // btnTagEmot
            // 
            this.btnTagEmot.Location = new System.Drawing.Point(15, 185);
            this.btnTagEmot.Name = "btnTagEmot";
            this.btnTagEmot.Size = new System.Drawing.Size(150, 23);
            this.btnTagEmot.TabIndex = 3;
            this.btnTagEmot.Text = "Tag emot";
            this.btnTagEmot.UseVisualStyleBackColor = true;
            this.btnTagEmot.Click += new System.EventHandler(this.btnTagEmot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 217);
            this.Controls.Add(this.btnTagEmot);
            this.Controls.Add(this.rtbReccived);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbReccived;
        private System.Windows.Forms.Button btnTagEmot;
    }
}

