namespace VideoRentalSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.addMoviesToolStripMenuItem,
            this.viewCustomerToolStripMenuItem,
            this.viewMovieToolStripMenuItem,
            this.issueMovieToolStripMenuItem,
            this.returnMovieToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.addCustomerToolStripMenuItem.Text = "Add Customers";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.AddCustomerToolStripMenuItem_Click);
            // 
            // addMoviesToolStripMenuItem
            // 
            this.addMoviesToolStripMenuItem.Name = "addMoviesToolStripMenuItem";
            this.addMoviesToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.addMoviesToolStripMenuItem.Text = "Add Movies";
            this.addMoviesToolStripMenuItem.Click += new System.EventHandler(this.AddMoviesToolStripMenuItem_Click);
            // 
            // viewCustomerToolStripMenuItem
            // 
            this.viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            this.viewCustomerToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.viewCustomerToolStripMenuItem.Text = "View Customer";
            this.viewCustomerToolStripMenuItem.Click += new System.EventHandler(this.ViewCustomerToolStripMenuItem_Click);
            // 
            // viewMovieToolStripMenuItem
            // 
            this.viewMovieToolStripMenuItem.Name = "viewMovieToolStripMenuItem";
            this.viewMovieToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.viewMovieToolStripMenuItem.Text = "View Movie";
            this.viewMovieToolStripMenuItem.Click += new System.EventHandler(this.ViewMovieToolStripMenuItem_Click);
            // 
            // issueMovieToolStripMenuItem
            // 
            this.issueMovieToolStripMenuItem.Name = "issueMovieToolStripMenuItem";
            this.issueMovieToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.issueMovieToolStripMenuItem.Text = "Issue Movie";
            this.issueMovieToolStripMenuItem.Click += new System.EventHandler(this.IssueMovieToolStripMenuItem_Click);
            // 
            // returnMovieToolStripMenuItem
            // 
            this.returnMovieToolStripMenuItem.Name = "returnMovieToolStripMenuItem";
            this.returnMovieToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.returnMovieToolStripMenuItem.Text = "Return Movie";
            this.returnMovieToolStripMenuItem.Click += new System.EventHandler(this.ReturnMovieToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 20);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}