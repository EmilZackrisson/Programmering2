﻿namespace Övning_1._7_Felsäkra_dina_program
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
            this.tbxEpost = new System.Windows.Forms.TextBox();
            this.tbxLösenord = new System.Windows.Forms.TextBox();
            this.btnSkapa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxEpost
            // 
            this.tbxEpost.Location = new System.Drawing.Point(12, 28);
            this.tbxEpost.Name = "tbxEpost";
            this.tbxEpost.Size = new System.Drawing.Size(235, 20);
            this.tbxEpost.TabIndex = 0;
            // 
            // tbxLösenord
            // 
            this.tbxLösenord.Location = new System.Drawing.Point(12, 70);
            this.tbxLösenord.Name = "tbxLösenord";
            this.tbxLösenord.Size = new System.Drawing.Size(154, 20);
            this.tbxLösenord.TabIndex = 1;
            // 
            // btnSkapa
            // 
            this.btnSkapa.Location = new System.Drawing.Point(172, 70);
            this.btnSkapa.Name = "btnSkapa";
            this.btnSkapa.Size = new System.Drawing.Size(75, 23);
            this.btnSkapa.TabIndex = 2;
            this.btnSkapa.Text = "Skapa";
            this.btnSkapa.UseVisualStyleBackColor = true;
            this.btnSkapa.Click += new System.EventHandler(this.btnSkapa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-postaddress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lösenord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 113);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSkapa);
            this.Controls.Add(this.tbxLösenord);
            this.Controls.Add(this.tbxEpost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEpost;
        private System.Windows.Forms.TextBox tbxLösenord;
        private System.Windows.Forms.Button btnSkapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

