namespace TCP_Async
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
            this.btnStartServer = new System.Windows.Forms.Button();
            this.gbxInkorg = new System.Windows.Forms.GroupBox();
            this.rtbInkorg = new System.Windows.Forms.RichTextBox();
            this.gbxInkorg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(290, 12);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(75, 23);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "Starta server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // gbxInkorg
            // 
            this.gbxInkorg.Controls.Add(this.rtbInkorg);
            this.gbxInkorg.Location = new System.Drawing.Point(12, 73);
            this.gbxInkorg.Name = "gbxInkorg";
            this.gbxInkorg.Size = new System.Drawing.Size(353, 187);
            this.gbxInkorg.TabIndex = 1;
            this.gbxInkorg.TabStop = false;
            this.gbxInkorg.Text = "Inkorg";
            // 
            // rtbInkorg
            // 
            this.rtbInkorg.Location = new System.Drawing.Point(7, 20);
            this.rtbInkorg.Name = "rtbInkorg";
            this.rtbInkorg.Size = new System.Drawing.Size(340, 161);
            this.rtbInkorg.TabIndex = 0;
            this.rtbInkorg.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 272);
            this.Controls.Add(this.gbxInkorg);
            this.Controls.Add(this.btnStartServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxInkorg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.GroupBox gbxInkorg;
        private System.Windows.Forms.RichTextBox rtbInkorg;
    }
}

