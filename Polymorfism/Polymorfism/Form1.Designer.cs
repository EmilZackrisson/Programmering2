namespace Polymorfism
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
            this.rbnTypA = new System.Windows.Forms.RadioButton();
            this.rbnTypB = new System.Windows.Forms.RadioButton();
            this.btnSkapa = new System.Windows.Forms.Button();
            this.tbxBeskrivning = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbnTypA
            // 
            this.rbnTypA.AutoSize = true;
            this.rbnTypA.Location = new System.Drawing.Point(12, 12);
            this.rbnTypA.Name = "rbnTypA";
            this.rbnTypA.Size = new System.Drawing.Size(53, 17);
            this.rbnTypA.TabIndex = 0;
            this.rbnTypA.TabStop = true;
            this.rbnTypA.Text = "Typ A";
            this.rbnTypA.UseVisualStyleBackColor = true;
            // 
            // rbnTypB
            // 
            this.rbnTypB.AutoSize = true;
            this.rbnTypB.Location = new System.Drawing.Point(104, 12);
            this.rbnTypB.Name = "rbnTypB";
            this.rbnTypB.Size = new System.Drawing.Size(53, 17);
            this.rbnTypB.TabIndex = 1;
            this.rbnTypB.TabStop = true;
            this.rbnTypB.Text = "Typ B";
            this.rbnTypB.UseVisualStyleBackColor = true;
            // 
            // btnSkapa
            // 
            this.btnSkapa.Location = new System.Drawing.Point(12, 56);
            this.btnSkapa.Name = "btnSkapa";
            this.btnSkapa.Size = new System.Drawing.Size(145, 23);
            this.btnSkapa.TabIndex = 2;
            this.btnSkapa.Text = "Skapa";
            this.btnSkapa.UseVisualStyleBackColor = true;
            this.btnSkapa.Click += new System.EventHandler(this.btnSkapa_Click);
            // 
            // tbxBeskrivning
            // 
            this.tbxBeskrivning.Location = new System.Drawing.Point(12, 103);
            this.tbxBeskrivning.Name = "tbxBeskrivning";
            this.tbxBeskrivning.ReadOnly = true;
            this.tbxBeskrivning.Size = new System.Drawing.Size(145, 20);
            this.tbxBeskrivning.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 149);
            this.Controls.Add(this.tbxBeskrivning);
            this.Controls.Add(this.btnSkapa);
            this.Controls.Add(this.rbnTypB);
            this.Controls.Add(this.rbnTypA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnTypA;
        private System.Windows.Forms.RadioButton rbnTypB;
        private System.Windows.Forms.Button btnSkapa;
        private System.Windows.Forms.TextBox tbxBeskrivning;
    }
}

