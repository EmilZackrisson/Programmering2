namespace Bataljonen
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bataljon");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.gbxNyEnhet = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNyAntal = new System.Windows.Forms.TextBox();
            this.tbxNyNamn = new System.Windows.Forms.TextBox();
            this.btnLäggTillNy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.gbxNyEnhet.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nBataljon";
            treeNode1.Text = "Bataljon";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(209, 207);
            this.treeView1.TabIndex = 0;
            this.treeView1.Tag = "root";
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // gbxNyEnhet
            // 
            this.gbxNyEnhet.Controls.Add(this.btnLäggTillNy);
            this.gbxNyEnhet.Controls.Add(this.tbxNyNamn);
            this.gbxNyEnhet.Controls.Add(this.tbxNyAntal);
            this.gbxNyEnhet.Controls.Add(this.label2);
            this.gbxNyEnhet.Controls.Add(this.label1);
            this.gbxNyEnhet.Location = new System.Drawing.Point(229, 13);
            this.gbxNyEnhet.Name = "gbxNyEnhet";
            this.gbxNyEnhet.Size = new System.Drawing.Size(200, 100);
            this.gbxNyEnhet.TabIndex = 1;
            this.gbxNyEnhet.TabStop = false;
            this.gbxNyEnhet.Text = "Lägg till ny enhet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Antal soldater:";
            // 
            // tbxNyAntal
            // 
            this.tbxNyAntal.Location = new System.Drawing.Point(86, 47);
            this.tbxNyAntal.Name = "tbxNyAntal";
            this.tbxNyAntal.Size = new System.Drawing.Size(100, 20);
            this.tbxNyAntal.TabIndex = 2;
            // 
            // tbxNyNamn
            // 
            this.tbxNyNamn.Location = new System.Drawing.Point(86, 20);
            this.tbxNyNamn.Name = "tbxNyNamn";
            this.tbxNyNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxNyNamn.TabIndex = 1;
            // 
            // btnLäggTillNy
            // 
            this.btnLäggTillNy.Location = new System.Drawing.Point(86, 71);
            this.btnLäggTillNy.Name = "btnLäggTillNy";
            this.btnLäggTillNy.Size = new System.Drawing.Size(100, 23);
            this.btnLäggTillNy.TabIndex = 3;
            this.btnLäggTillNy.Text = "Ny enhet";
            this.btnLäggTillNy.UseVisualStyleBackColor = true;
            this.btnLäggTillNy.Click += new System.EventHandler(this.btnLäggTillNy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbInfo);
            this.groupBox2.Location = new System.Drawing.Point(229, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information om vald enhet";
            // 
            // rtbInfo
            // 
            this.rtbInfo.Enabled = false;
            this.rtbInfo.Location = new System.Drawing.Point(7, 20);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(187, 74);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 229);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxNyEnhet);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxNyEnhet.ResumeLayout(false);
            this.gbxNyEnhet.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox gbxNyEnhet;
        private System.Windows.Forms.Button btnLäggTillNy;
        private System.Windows.Forms.TextBox tbxNyNamn;
        private System.Windows.Forms.TextBox tbxNyAntal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbInfo;
    }
}

