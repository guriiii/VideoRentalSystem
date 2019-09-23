namespace VideoRentalSystem
{
    partial class UpdateAndDeleteMovie
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
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(229, 49);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(411, 20);
            this.txtMovieID.TabIndex = 85;
            this.txtMovieID.Visible = false;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDeleteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMovie.Location = new System.Drawing.Point(496, 330);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(125, 71);
            this.btnDeleteMovie.TabIndex = 84;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.BtnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMovie.Location = new System.Drawing.Point(222, 330);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(125, 71);
            this.btnUpdateMovie.TabIndex = 77;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.BtnUpdateMovie_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(229, 270);
            this.txtGenre.Multiline = true;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(411, 26);
            this.txtGenre.TabIndex = 76;
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(229, 236);
            this.txtPlot.Multiline = true;
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(411, 28);
            this.txtPlot.TabIndex = 75;
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(229, 210);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(411, 20);
            this.txtCopies.TabIndex = 74;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(229, 184);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(411, 20);
            this.txtYear.TabIndex = 73;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(229, 99);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(411, 24);
            this.txtTitle.TabIndex = 71;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(229, 145);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(411, 20);
            this.txtRating.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(160, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(160, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Plot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(160, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Copies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(160, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(160, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(160, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Rating";
            // 
            // UpdateAndDeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateAndDeleteMovie";
            this.Text = "UpdateAndDeleteMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        public System.Windows.Forms.TextBox txtGenre;
        public System.Windows.Forms.TextBox txtPlot;
        public System.Windows.Forms.TextBox txtCopies;
        public System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.TextBox txtRating;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}