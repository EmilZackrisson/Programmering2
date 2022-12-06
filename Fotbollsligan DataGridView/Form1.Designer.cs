namespace Fotbollsligan_DataGridView
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
            this.dgvMatcher = new System.Windows.Forms.DataGridView();
            this.colHemmalag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolBortalag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMålH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMålB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMålrikast = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStörstaMålskillnad = new System.Windows.Forms.Button();
            this.btnUpp = new System.Windows.Forms.Button();
            this.btnNer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatcher
            // 
            this.dgvMatcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatcher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHemmalag,
            this.bolBortalag,
            this.colMålH,
            this.colMålB});
            this.dgvMatcher.Location = new System.Drawing.Point(12, 12);
            this.dgvMatcher.MultiSelect = false;
            this.dgvMatcher.Name = "dgvMatcher";
            this.dgvMatcher.Size = new System.Drawing.Size(445, 187);
            this.dgvMatcher.TabIndex = 0;
            this.dgvMatcher.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatcher_CellEndEdit);
            this.dgvMatcher.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvMatcher_UserAddedRow);
            this.dgvMatcher.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvMatcher_UserDeletingRow);
            // 
            // colHemmalag
            // 
            this.colHemmalag.HeaderText = "Hemmalag";
            this.colHemmalag.Name = "colHemmalag";
            // 
            // bolBortalag
            // 
            this.bolBortalag.HeaderText = "Bortalag";
            this.bolBortalag.Name = "bolBortalag";
            // 
            // colMålH
            // 
            this.colMålH.HeaderText = "Mål (H)";
            this.colMålH.Name = "colMålH";
            // 
            // colMålB
            // 
            this.colMålB.HeaderText = "Mål (B)";
            this.colMålB.Name = "colMålB";
            // 
            // btnMålrikast
            // 
            this.btnMålrikast.Location = new System.Drawing.Point(12, 203);
            this.btnMålrikast.Name = "btnMålrikast";
            this.btnMålrikast.Size = new System.Drawing.Size(82, 23);
            this.btnMålrikast.TabIndex = 1;
            this.btnMålrikast.Text = "Målrikast";
            this.btnMålrikast.UseVisualStyleBackColor = true;
            this.btnMålrikast.Click += new System.EventHandler(this.btnMålrikast_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnStörstaMålskillnad
            // 
            this.btnStörstaMålskillnad.Location = new System.Drawing.Point(12, 233);
            this.btnStörstaMålskillnad.Name = "btnStörstaMålskillnad";
            this.btnStörstaMålskillnad.Size = new System.Drawing.Size(110, 23);
            this.btnStörstaMålskillnad.TabIndex = 3;
            this.btnStörstaMålskillnad.Text = "Största Målskillnad";
            this.btnStörstaMålskillnad.UseVisualStyleBackColor = true;
            this.btnStörstaMålskillnad.Click += new System.EventHandler(this.btnStörstaMålskillnad_Click);
            // 
            // btnUpp
            // 
            this.btnUpp.Location = new System.Drawing.Point(382, 233);
            this.btnUpp.Name = "btnUpp";
            this.btnUpp.Size = new System.Drawing.Size(75, 23);
            this.btnUpp.TabIndex = 4;
            this.btnUpp.Text = "Flytta Upp";
            this.btnUpp.UseVisualStyleBackColor = true;
            this.btnUpp.Click += new System.EventHandler(this.btnUpp_Click);
            // 
            // btnNer
            // 
            this.btnNer.Location = new System.Drawing.Point(382, 263);
            this.btnNer.Name = "btnNer";
            this.btnNer.Size = new System.Drawing.Size(75, 23);
            this.btnNer.TabIndex = 5;
            this.btnNer.Text = "Flytta Ner";
            this.btnNer.UseVisualStyleBackColor = true;
            this.btnNer.Click += new System.EventHandler(this.btnNer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 294);
            this.Controls.Add(this.btnNer);
            this.Controls.Add(this.btnUpp);
            this.Controls.Add(this.btnStörstaMålskillnad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMålrikast);
            this.Controls.Add(this.dgvMatcher);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatcher;
        private System.Windows.Forms.Button btnMålrikast;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHemmalag;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolBortalag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMålH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMålB;
        private System.Windows.Forms.Button btnStörstaMålskillnad;
        private System.Windows.Forms.Button btnUpp;
        private System.Windows.Forms.Button btnNer;
    }
}

