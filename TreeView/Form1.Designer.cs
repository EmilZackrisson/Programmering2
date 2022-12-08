namespace TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Test", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node9", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnSkapaNoder = new System.Windows.Forms.Button();
            this.tbxNodeName = new System.Windows.Forms.TextBox();
            this.lblSelectedNodeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node6";
            treeNode1.Text = "Node6";
            treeNode2.Name = "Node7";
            treeNode2.Text = "Node7";
            treeNode3.Name = "Node8";
            treeNode3.Text = "Node8";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Test";
            treeNode5.Name = "Node10";
            treeNode5.Text = "Node10";
            treeNode6.Name = "Node11";
            treeNode6.Text = "Node11";
            treeNode7.Name = "Node9";
            treeNode7.Text = "Node9";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(153, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnSkapaNoder
            // 
            this.btnSkapaNoder.Location = new System.Drawing.Point(197, 12);
            this.btnSkapaNoder.Name = "btnSkapaNoder";
            this.btnSkapaNoder.Size = new System.Drawing.Size(75, 23);
            this.btnSkapaNoder.TabIndex = 1;
            this.btnSkapaNoder.Text = "Lägg till nod";
            this.btnSkapaNoder.UseVisualStyleBackColor = true;
            this.btnSkapaNoder.Click += new System.EventHandler(this.btnSkapaNoder_Click);
            // 
            // tbxNodeName
            // 
            this.tbxNodeName.Location = new System.Drawing.Point(197, 70);
            this.tbxNodeName.Name = "tbxNodeName";
            this.tbxNodeName.Size = new System.Drawing.Size(100, 20);
            this.tbxNodeName.TabIndex = 2;
            // 
            // lblSelectedNodeName
            // 
            this.lblSelectedNodeName.AutoSize = true;
            this.lblSelectedNodeName.Location = new System.Drawing.Point(197, 54);
            this.lblSelectedNodeName.Name = "lblSelectedNodeName";
            this.lblSelectedNodeName.Size = new System.Drawing.Size(88, 13);
            this.lblSelectedNodeName.TabIndex = 3;
            this.lblSelectedNodeName.Text = "Node name: N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelectedNodeName);
            this.Controls.Add(this.tbxNodeName);
            this.Controls.Add(this.btnSkapaNoder);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnSkapaNoder;
        private System.Windows.Forms.TextBox tbxNodeName;
        private System.Windows.Forms.Label lblSelectedNodeName;
    }
}

